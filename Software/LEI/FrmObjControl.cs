using LEICore.Objects;
using LEICore.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LEI
{
    public partial class FrmObjControl : Form
    {
        User user = new User();
        ObjectRepository objectRepository = new ObjectRepository();

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
            List<LEICore.Objects.Object> objlist = new List<LEICore.Objects.Object>();
            ObjectRepository objectRepository = new ObjectRepository();

            objlist = objectRepository.GetObjects(user.Id);

            if (objlist != null && objlist.Count > 0)
            {
                dvgObjects.DataSource = objlist;
                dvgObjects.Columns["Id"].DisplayIndex = 0;
                dvgObjects.Columns["Name"].DisplayIndex = 1;
                dvgObjects.Columns["City"].DisplayIndex = 2;
                dvgObjects.Columns["Street"].DisplayIndex = 3;
                dvgObjects.Columns["ObjectType"].DisplayIndex = 4;
            }
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
                        LoadData();
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
            LoadData();
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
            LoadData();
        }
    }
}
