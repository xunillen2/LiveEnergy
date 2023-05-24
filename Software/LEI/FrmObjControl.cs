using LEICore.Consumption;
using LEICore.Objects;
using LEICore.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LEI
{
    /// <summary>
    /// Displays form For Managing Objects.
    /// </summary>
    public partial class FrmObjControl : Form
    {
        User user = new User();
        ObjectRepository objectRepository = new ObjectRepository();
        List<LEICore.Objects.Object> objectList = new List<LEICore.Objects.Object>();

        public FrmObjControl(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void FrmObjControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            ObjectRepository objectRepository = new ObjectRepository();

            // If user is admin, get all objects.
            if (!user.IsAdmin())
                objectList = objectRepository.GetObjects(user.Id);
            else
                objectList = objectRepository.GetObjects();

            if (objectList != null && objectList.Count > 0)
            {
                dvgObjects.DataSource = objectList;
                SetDvgLayout();
            }
        }
        private void SetDvgLayout ()
        {
            /* Sets Columns idexes, header text and hides
            * Columns that are not needed in this Form.
            */
            dvgObjects.Columns["Id"].DisplayIndex = 0;
            dvgObjects.Columns["Name"].DisplayIndex = 1;
            dvgObjects.Columns["City"].DisplayIndex = 2;
            dvgObjects.Columns["Street"].DisplayIndex = 3;
            dvgObjects.Columns["ObjectType"].DisplayIndex = 4;

            dvgObjects.Columns[1].HeaderText = "Ime";
            dvgObjects.Columns[2].HeaderText = "Grad";
            dvgObjects.Columns[3].HeaderText = "Ulica";
            dvgObjects.Columns[4].HeaderText = "Tip Objekta";
            dvgObjects.Columns[5].HeaderText = "Senzor";
            dvgObjects.Columns[6].HeaderText = "Korisnik";
            dvgObjects.Columns[7].HeaderText = "Predviđena potrošnja";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (LblError.Visible)
            {
                LblError.Visible = false;
            }

            if (dvgObjects.SelectedRows.Count > 0) {
                LEICore.Objects.Object selectedObject = dvgObjects.CurrentRow.DataBoundItem 
                    as LEICore.Objects.Object;

                if (selectedObject != null)
                {
                    if (objectRepository.DropObject(selectedObject.Id) == 1)
                    {
                        txtSearch.Text = "";    //Clear filter
                        LoadData();             // Reload Dvg data
                    }
                    else
                    {
                        LblError.Visible = true;
                        LblError.Text = "Greška tijekom micanja Objekta";
                    }
                }
            }
            else
            {
                LblError.Visible = true;
                LblError.Text = "Nije Odabran objekt";
            }
        }

        private void dvgObjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LblError.Visible) {
                LblError.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmObjAdd frmObjAdd = new FrmObjAdd();
            frmObjAdd.ShowDialog();
            txtSearch.Text = "";    // Clear filter
            LoadData();             // Reload data
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dvgObjects.SelectedRows.Count > 0)
            {
                LEICore.Objects.Object selectedObject = dvgObjects.CurrentRow.DataBoundItem
                    as LEICore.Objects.Object;

                if (selectedObject != null)
                {
                    FrmObjAdd frmObjAdd = new FrmObjAdd(selectedObject);
                    frmObjAdd.ShowDialog();
                }
            }
            else
            {
                LblError.Visible = true;
                LblError.Text = "Nije Odabran objekt";
            }
            txtSearch.Text = "";    // Clear filter
            LoadData();             // Reload data
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<LEICore.Objects.Object> ObjectListFilterd = new List<LEICore.Objects.Object>();

            // Go through current Objects and match it with a string.
            // If Object matches, copy Object to new filtered List.
            dvgObjects.DataSource = null;
            foreach (LEICore.Objects.Object odata in objectList)
            {
                if (odata.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) || 
                    odata.Street.ToUpper().Contains(txtSearch.Text.ToUpper()) ||
                    odata.City.ToUpper().Contains(txtSearch.Text.ToUpper()) || 
                    odata.User.FirstName.ToUpper().Contains(txtSearch.Text.ToUpper()) ||
                    odata.User.LastName.ToUpper().Contains(txtSearch.Text.ToUpper()))
                        ObjectListFilterd.Add(odata);
            }

            dvgObjects.DataSource = ObjectListFilterd;
            SetDvgLayout();
        }
    }
}
