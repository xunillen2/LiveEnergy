﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using LEICore.Users;

namespace LEI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {

            InitializeComponent();
            UserRepository userRepository = new UserRepository();
            User user = userRepository.GetUser("mmaric");

                FrmMain frmMain = new FrmMain(user);
                frmMain.ShowDialog();
                this.Close();
            }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                LblError.Visible = true;
                LblError.Text = "Nije uneseno korisničko ime";
            }
            else if (txtPassword.Text == "")
            {
                LblError.Visible = true;
                LblError.Text = "Nije unesena lozinka";
            }
            else { 
                UserRepository userRepository = new UserRepository();
                User user = userRepository.GetUser(txtUsername.Text);
                if (user != null && user.Password == txtPassword.Text)
                {

                    FrmMain frmMain = new FrmMain(user);
                    frmMain.ShowDialog();
                    this.Close();
                }
                else {
                    LblError.Visible = true;
                    LblError.Text = "Korisničko ime ili lozinka su krivi";
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            CheckLblErrorVisibility();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckLblErrorVisibility();
        }

        void CheckLblErrorVisibility() {
            if (LblError.Visible) {
                LblError.Visible = false;
            }
        }
    }
}