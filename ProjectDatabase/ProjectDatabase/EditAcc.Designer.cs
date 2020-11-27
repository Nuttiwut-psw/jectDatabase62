namespace ProjectDatabase
{
    partial class EditAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAcc));
            this.label1 = new System.Windows.Forms.Label();
            this.Acc_Info = new System.Windows.Forms.DataGridView();
            this.pass_change = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Info";
            // 
            // Acc_Info
            // 
            this.Acc_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Acc_Info.Location = new System.Drawing.Point(0, 109);
            this.Acc_Info.Name = "Acc_Info";
            this.Acc_Info.RowHeadersWidth = 51;
            this.Acc_Info.RowTemplate.Height = 24;
            this.Acc_Info.Size = new System.Drawing.Size(882, 83);
            this.Acc_Info.TabIndex = 1;
            this.Acc_Info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Acc_Info_CellContentClick);
            // 
            // pass_change
            // 
            this.pass_change.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_change.Location = new System.Drawing.Point(0, 216);
            this.pass_change.Name = "pass_change";
            this.pass_change.Size = new System.Drawing.Size(439, 77);
            this.pass_change.TabIndex = 2;
            this.pass_change.Text = "Change password";
            this.pass_change.UseVisualStyleBackColor = true;
            this.pass_change.Click += new System.EventHandler(this.pass_change_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(676, 415);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(235, 77);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // EditAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 504);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pass_change);
            this.Controls.Add(this.Acc_Info);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditAcc";
            this.Text = "Account info";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Acc_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Acc_Info;
        private System.Windows.Forms.Button pass_change;
        private System.Windows.Forms.Button logout;
    }
}