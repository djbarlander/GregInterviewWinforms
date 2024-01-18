using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregInterviewWinforms
{
    public partial class Form1 : Form
    {
        public BindingSource bs = new BindingSource();
        public StaffEntities db = new StaffEntities();
        private Staff staffDetail = null;
        private List<StaffTitle> staffTitles;
        private List<StaffType> StaffTypesList;
        private List<StaffStatu> StaffStatusList;

        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshDataGridView()
        {
            bs.DataSource = db.vw_Staff.ToList();
            dgvMain.DataSource = bs;
            dgvMain.ClearSelection();

            //dgvMain.ResetBindings();
            //bs.ResetBindings(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            staffTitles = db.StaffTitles.ToList();
            cbTitle.DataSource = staffTitles;
            StaffTypesList = db.StaffTypes.ToList();
            cbStaffType.DataSource = StaffTypesList;
            StaffStatusList = db.StaffStatus.ToList();
            cbStaffStatus.DataSource = StaffStatusList;
            bs.DataSource = db.vw_Staff.ToList();
            dgvMain.DataSource = bs;
            dgvMain.ClearSelection();
            btnCancel.Visible = false;
            btnEdit.Visible = false;
            btnSave.Visible = false;
            btnNew.Visible = true;
            btnDelete.Visible = false;
            SetGBStaffDetailReadOnly(true);
        }

        #region Data

        #endregion

        private void btn_CSV_Click(object sender, EventArgs e)
        {
            var csv = CreateCSV();
            MessageBox.Show(csv);
        }

        private string CreateCSV()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("StaffID,FirstName,LastName");

            var staffs = db.Staffs.ToList();
            foreach (var staff in staffs)
            {
                sb.AppendLine($"{staff.StaffID},{staff.FirstName},{staff.LastName}");
            }

            return sb.ToString();
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            var rows = dgv.SelectedRows;
            switch (rows.Count)
            {
                case 0:
                    staffDetail = null;
                    ClearGBStaffDetail();
                    break;
                case 1:
                    var row = rows[0];
                    staffDetail = db.Staffs.Single(s => s.StaffID == ((vw_Staff)row.DataBoundItem).StaffID);
                    PopulateStaffGroup();
                    break;
                default:
                    throw new Exception(String.Format("Error, expected 0 or 1 rows selected, but received {0}", rows.Count));
            }
        }

        /// <summary>
        /// Clears all the controls in the GroupBox
        /// </summary>
        private void ClearGBStaffDetail()
        {
            foreach (var control in gbStaffDetail.Controls)
            {
                if (control is TextBox)
                {
                    var c = control as TextBox;
                    c.Text = "";
                    continue;
                }
                if (control is ComboBox)
                {
                    var c = control as ComboBox;
                    c.SelectedIndex = -1;
                    continue;
                }
            }
        }

        /// <summary>
        /// Makes all the controls in the groupbox readonly
        /// </summary>
        /// <param name="readOnly">Readonly, otherwise Read/Write</param>
        private void SetGBStaffDetailReadOnly(bool readOnly)
        {
            foreach (var control in gbStaffDetail.Controls)
            {
                if (control is TextBox)
                {
                    var c = control as TextBox;
                    c.ReadOnly = readOnly;
                    continue;
                }
                if (control is ComboBox)
                {
                    var c = control as ComboBox;
                    c.Enabled = !readOnly;
                    continue;
                }
            }

        }

        private void PopulateStaffGroup()
        {
            if (staffDetail == null)
                throw new DataException("Tried to populate Staff groupbox but staffDetail is null");
            cbTitle.SelectedValue = staffDetail.StaffTitleID;
            txtFName.Text = staffDetail.FirstName;
            txtMInitial.Text = staffDetail.MiddleInitial;
            txtLName.Text = staffDetail.LastName;
            txtPhHome.Text = staffDetail.PhHome;
            txtPhCell.Text = staffDetail.PhCell;
            txtPhExt.Text = staffDetail.PhExt;
            txtIRD.Text = staffDetail.IRD;
            cbStaffType.SelectedValue = staffDetail.StaffTypeID;
            cbStaffStatus.SelectedValue = staffDetail.StaffStatusID;
            SetGBStaffDetailReadOnly(true);
            btnEdit.Visible = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnNew.Visible = false;
            btnEdit.Visible = false;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnDelete.Visible = true;
            SetGBStaffDetailReadOnly(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (staffDetail is null)
            {
                ClearGBStaffDetail();
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                PopulateStaffGroup();
                btnEdit.Visible = true;
                btnDelete.Visible = false;
            }
            SetGBStaffDetailReadOnly(true);
            btnCancel.Visible = false;
            btnSave.Visible = false;
            btnNew.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (staffDetail is null)
                {
                    //Inserting a new Staff
                    //TODO : optimise
                    var newStaff = new Staff();
                    newStaff.StaffTitleID = (int)cbTitle.SelectedValue;
                    newStaff.FirstName = txtFName.Text;
                    newStaff.MiddleInitial = txtMInitial.Text;
                    newStaff.LastName = txtLName.Text;
                    newStaff.PhHome = txtPhHome.Text;
                    newStaff.PhCell = txtPhCell.Text;
                    newStaff.PhExt = txtPhExt.Text;
                    newStaff.IRD = txtIRD.Text;
                    newStaff.StaffTypeID = (int)cbStaffType.SelectedValue;
                    newStaff.StaffStatusID = (int)cbStaffStatus.SelectedValue;
                    db.Staffs.Add(newStaff);
                    MessageBox.Show("New staff member successfully created.");

                    RefreshDataGridView();
                }
                else
                {
                    //Updating existing staff
                    //TODO : optimise
                    staffDetail.StaffTitleID = (int)cbTitle.SelectedValue;
                    staffDetail.FirstName = txtFName.Text;
                    staffDetail.MiddleInitial = txtMInitial.Text;
                    staffDetail.LastName = txtLName.Text;
                    staffDetail.PhHome = txtPhHome.Text;
                    staffDetail.PhCell = txtPhCell.Text;
                    staffDetail.PhExt = txtPhExt.Text;
                    staffDetail.IRD = txtIRD.Text;
                    staffDetail.StaffTypeID = (int)cbStaffType.SelectedValue;
                    staffDetail.StaffStatusID = (int)cbStaffStatus.SelectedValue;
                    MessageBox.Show("Existing staff member successfully updated.");
                }
                db.SaveChanges();
                RefreshDataGridView();
                ClearGBStaffDetail();
                btnSave.Visible = false;
                btnCancel.Visible = false;
                btnDelete.Visible = false;
                dgvMain.ClearSelection();
                SetGBStaffDetailReadOnly(false);
                staffDetail = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error saving: {0}", ex.Message));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (staffDetail != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Deleting existing staff
                        // TODO: optimise
                        db.Staffs.Remove(staffDetail);
                        db.SaveChanges();

                        MessageBox.Show("Existing staff member successfully deleted.");

                        RefreshDataGridView();

                        ClearGBStaffDetail();
                        btnNew.Visible = true;
                        btnSave.Visible = false;
                        btnCancel.Visible = false;
                        btnDelete.Visible = false;
                        dgvMain.ClearSelection();
                        SetGBStaffDetailReadOnly(true);
                        staffDetail = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a staff member to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting: {ex.Message}");
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvMain.ClearSelection();
            ClearGBStaffDetail();
            SetGBStaffDetailReadOnly(false);
            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnNew.Visible = false;
            btnCancel.Visible = true;
            btnDelete.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        


        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Blank Summary Template
        /// </summary>
        /// <param name="SpaceHolder"SpaceHolder>, otherwise Read/Write</param>
    }
}
