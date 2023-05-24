namespace LEI
{
    partial class FrmObjInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjInfo));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblObjName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dvgWater = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvgGas = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dvgElectric = new System.Windows.Forms.DataGridView();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgWater)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgElectric)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(103, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sve u redu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(128, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LEI.Properties.Resources.ok_status;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 173);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblObjName
            // 
            this.lblObjName.AutoSize = true;
            this.lblObjName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblObjName.ForeColor = System.Drawing.Color.White;
            this.lblObjName.Location = new System.Drawing.Point(483, 24);
            this.lblObjName.Name = "lblObjName";
            this.lblObjName.Size = new System.Drawing.Size(102, 16);
            this.lblObjName.TabIndex = 11;
            this.lblObjName.Text = "{Ime Objekta}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(346, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Grad:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCity.Location = new System.Drawing.Point(412, 80);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 15);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "{City}";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStreet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStreet.Location = new System.Drawing.Point(412, 125);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(43, 15);
            this.lblStreet.TabIndex = 15;
            this.lblStreet.Text = "{Ulica}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(346, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ulica:";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOwner.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblOwner.Location = new System.Drawing.Point(412, 173);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(43, 15);
            this.lblOwner.TabIndex = 17;
            this.lblOwner.Text = "{Ulica}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(346, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Vlasnik:";
            // 
            // dvgWater
            // 
            this.dvgWater.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgWater.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgWater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgWater.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgWater.Location = new System.Drawing.Point(0, 0);
            this.dvgWater.MultiSelect = false;
            this.dvgWater.Name = "dvgWater";
            this.dvgWater.ReadOnly = true;
            this.dvgWater.RowHeadersVisible = false;
            this.dvgWater.Size = new System.Drawing.Size(770, 345);
            this.dvgWater.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 257);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 371);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvgWater);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Voda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dvgGas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dvgGas
            // 
            this.dvgGas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dvgGas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgGas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgGas.Location = new System.Drawing.Point(0, 0);
            this.dvgGas.MultiSelect = false;
            this.dvgGas.Name = "dvgGas";
            this.dvgGas.ReadOnly = true;
            this.dvgGas.RowHeadersVisible = false;
            this.dvgGas.Size = new System.Drawing.Size(770, 345);
            this.dvgGas.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dvgElectric);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(770, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Struja";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dvgElectric
            // 
            this.dvgElectric.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.dvgElectric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgElectric.DefaultCellStyle = dataGridViewCellStyle4;
            this.dvgElectric.Location = new System.Drawing.Point(0, 0);
            this.dvgElectric.MultiSelect = false;
            this.dvgElectric.Name = "dvgElectric";
            this.dvgElectric.ReadOnly = true;
            this.dvgElectric.RowHeadersVisible = false;
            this.dvgElectric.Size = new System.Drawing.Size(770, 345);
            this.dvgElectric.TabIndex = 19;
            // 
            // dateFilter
            // 
            this.dateFilter.Location = new System.Drawing.Point(642, 249);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(113, 20);
            this.dateFilter.TabIndex = 20;
            this.dateFilter.Value = new System.DateTime(2023, 5, 24, 12, 33, 50, 0);
            this.dateFilter.ValueChanged += new System.EventHandler(this.dateFilter_ValueChanged);
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveFilter.Location = new System.Drawing.Point(761, 247);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(25, 23);
            this.btnRemoveFilter.TabIndex = 21;
            this.btnRemoveFilter.Text = "X";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // FrmObjInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(802, 640);
            this.Controls.Add(this.btnRemoveFilter);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblObjName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 689);
            this.MinimumSize = new System.Drawing.Size(818, 679);
            this.Name = "FrmObjInfo";
            this.Text = "Informacije o objektu";
            this.Load += new System.EventHandler(this.ObjInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgWater)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgGas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgElectric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblObjName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvgWater;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dvgGas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dvgElectric;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.Button btnRemoveFilter;
    }
}