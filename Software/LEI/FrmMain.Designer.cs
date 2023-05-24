namespace LEI
{
    partial class FrmMain
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRemoveObj = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSensors = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgObjects = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblElectrConsumption = new System.Windows.Forms.Label();
            this.lblWaterConsumption = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGasConsumption = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikToolStripMenuItem,
            this.objectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogOut});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(111, 22);
            this.btnLogOut.Text = "Odjava";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // objectToolStripMenuItem
            // 
            this.objectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRemoveObj,
            this.btnSensors});
            this.objectToolStripMenuItem.Name = "objectToolStripMenuItem";
            this.objectToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.objectToolStripMenuItem.Text = "Objekti";
            // 
            // btnAddRemoveObj
            // 
            this.btnAddRemoveObj.Name = "btnAddRemoveObj";
            this.btnAddRemoveObj.Size = new System.Drawing.Size(180, 22);
            this.btnAddRemoveObj.Text = "Dodaj/Ukloni";
            this.btnAddRemoveObj.Click += new System.EventHandler(this.btnAddRemoveObj_Click);
            // 
            // btnSensors
            // 
            this.btnSensors.Name = "btnSensors";
            this.btnSensors.Size = new System.Drawing.Size(180, 22);
            this.btnSensors.Text = "Senzori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista Objekta:";
            // 
            // dvgObjects
            // 
            this.dvgObjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.dvgObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgObjects.Location = new System.Drawing.Point(0, 394);
            this.dvgObjects.Name = "dvgObjects";
            this.dvgObjects.Size = new System.Drawing.Size(252, 381);
            this.dvgObjects.TabIndex = 4;
            this.dvgObjects.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgObjects_CellContentDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sve u redu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(108, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(395, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Generalna sveukupna potrošnja struje (po min):";
            // 
            // lblElectrConsumption
            // 
            this.lblElectrConsumption.AutoSize = true;
            this.lblElectrConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblElectrConsumption.ForeColor = System.Drawing.Color.White;
            this.lblElectrConsumption.Location = new System.Drawing.Point(496, 92);
            this.lblElectrConsumption.Name = "lblElectrConsumption";
            this.lblElectrConsumption.Size = new System.Drawing.Size(140, 39);
            this.lblElectrConsumption.TabIndex = 9;
            this.lblElectrConsumption.Text = "13 kWh";
            // 
            // lblWaterConsumption
            // 
            this.lblWaterConsumption.AutoSize = true;
            this.lblWaterConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWaterConsumption.ForeColor = System.Drawing.Color.White;
            this.lblWaterConsumption.Location = new System.Drawing.Point(496, 245);
            this.lblWaterConsumption.Name = "lblWaterConsumption";
            this.lblWaterConsumption.Size = new System.Drawing.Size(140, 39);
            this.lblWaterConsumption.TabIndex = 11;
            this.lblWaterConsumption.Text = "13 kWh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(395, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(330, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Generalna sveukupna potrošnja vode (po min):";
            // 
            // lblGasConsumption
            // 
            this.lblGasConsumption.AutoSize = true;
            this.lblGasConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGasConsumption.ForeColor = System.Drawing.Color.White;
            this.lblGasConsumption.Location = new System.Drawing.Point(496, 375);
            this.lblGasConsumption.Name = "lblGasConsumption";
            this.lblGasConsumption.Size = new System.Drawing.Size(140, 39);
            this.lblGasConsumption.TabIndex = 13;
            this.lblGasConsumption.Text = "13 kWh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(399, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(329, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Generalna sveukupna potrošnja plina (po min):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LEI.Properties.Resources.ok_status;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 173);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(853, 778);
            this.Controls.Add(this.lblGasConsumption);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblWaterConsumption);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblElectrConsumption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvgObjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddRemoveObj;
        private System.Windows.Forms.ToolStripMenuItem btnSensors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgObjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblElectrConsumption;
        private System.Windows.Forms.Label lblWaterConsumption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGasConsumption;
        private System.Windows.Forms.Label label9;
    }
}