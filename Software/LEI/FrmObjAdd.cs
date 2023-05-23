using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LEICore.Objects;
using LEICore.Sensors;

namespace LEI
{
    public partial class FrmObjAdd : Form
    {
        public FrmObjAdd()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            LEICore.Objects.Object obj = new LEICore.Objects.Object();

            obj.Id = 213;
            obj.Name = txtName.Text;
            obj.City = txtCity.Text; ;
            obj.Street = txtStreet.Text;
            obj.ObjectType = (objectType) cmboType.SelectedIndex;
            
        }
    }
}
