namespace LEI
{
    partial class FrmObjAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.objectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPredicted = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(92, 129);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(182, 13);
            this.txtCity.TabIndex = 4;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grad:";
            // 
            // cmboType
            // 
            this.cmboType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cmboType.ForeColor = System.Drawing.Color.White;
            this.cmboType.FormattingEnabled = true;
            this.cmboType.Items.AddRange(new object[] {
            "Kuća",
            "Zgrada",
            "Industrijski objekt"});
            this.cmboType.Location = new System.Drawing.Point(92, 96);
            this.cmboType.Name = "cmboType";
            this.cmboType.Size = new System.Drawing.Size(182, 21);
            this.cmboType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ulica:";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.ForeColor = System.Drawing.Color.White;
            this.txtStreet.Location = new System.Drawing.Point(92, 176);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(182, 13);
            this.txtStreet.TabIndex = 8;
            this.txtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ime Objekta:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(92, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 13);
            this.txtName.TabIndex = 10;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // objectBindingSource
            // 
            this.objectBindingSource.DataSource = typeof(LEICore.Objects.Object);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vrsta Objekta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Predviđena potrošnja:";
            // 
            // txtPredicted
            // 
            this.txtPredicted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.txtPredicted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPredicted.ForeColor = System.Drawing.Color.White;
            this.txtPredicted.Location = new System.Drawing.Point(136, 212);
            this.txtPredicted.Name = "txtPredicted";
            this.txtPredicted.Size = new System.Drawing.Size(182, 13);
            this.txtPredicted.TabIndex = 13;
            this.txtPredicted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(343, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmObjAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(433, 501);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPredicted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.cmboType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCity);
            this.Name = "FrmObjAdd";
            this.Text = "FrmObjAdd";
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboType;
        private System.Windows.Forms.BindingSource objectBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPredicted;
        private System.Windows.Forms.Button btnSave;
    }
}