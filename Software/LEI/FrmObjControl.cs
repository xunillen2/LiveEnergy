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
                dvgObjects.Columns["Name"].DisplayIndex = 0;
                dvgObjects.Columns["City"].DisplayIndex = 1;
                dvgObjects.Columns["Street"].DisplayIndex = 2;
                dvgObjects.Columns["ObjectType"].DisplayIndex = 3;
            }
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
    }
}
