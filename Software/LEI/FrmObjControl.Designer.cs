namespace LEI
{
    partial class FrmObjControl
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.dvgObjects = new System.Windows.Forms.DataGridView();
            this.LblError = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(330, 397);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Ukloni";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dvgObjects
            // 
            this.dvgObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgObjects.Location = new System.Drawing.Point(12, 12);
            this.dvgObjects.Name = "dvgObjects";
            this.dvgObjects.Size = new System.Drawing.Size(474, 379);
            this.dvgObjects.TabIndex = 1;
            this.dvgObjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgObjects_CellContentClick);
            // 
            // LblError
            // 
            this.LblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(12, 402);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(103, 13);
            this.LblError.TabIndex = 3;
            this.LblError.Text = "Nije Odabran Objekt";
            this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblError.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(411, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmObjControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(498, 445);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.dvgObjects);
            this.Controls.Add(this.btnRemove);
            this.MaximumSize = new System.Drawing.Size(514, 484);
            this.MinimumSize = new System.Drawing.Size(417, 484);
            this.Name = "FrmObjControl";
            this.Text = "Upravljanje Objektima";
            this.Load += new System.EventHandler(this.FrmObjControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dvgObjects;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Button btnAdd;
    }
}