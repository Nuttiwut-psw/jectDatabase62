namespace ProjectDatabase
{
    partial class Acc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acc));
            this.label1 = new System.Windows.Forms.Label();
            this.Tour_display = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.acc_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_text = new System.Windows.Forms.TextBox();
            this.Detour = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tour_display)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account :";
            // 
            // Tour_display
            // 
            this.Tour_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tour_display.Location = new System.Drawing.Point(3, 182);
            this.Tour_display.Name = "Tour_display";
            this.Tour_display.RowHeadersWidth = 51;
            this.Tour_display.RowTemplate.Height = 24;
            this.Tour_display.Size = new System.Drawing.Size(882, 211);
            this.Tour_display.TabIndex = 1;
            this.Tour_display.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tour_display_CellContentClick);
            this.Tour_display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tour_display_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your tour";
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DarkKhaki;
            this.edit.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(807, 464);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(232, 76);
            this.edit.TabIndex = 3;
            this.edit.Text = "Add tour";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // acc_name
            // 
            this.acc_name.AutoSize = true;
            this.acc_name.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_name.Location = new System.Drawing.Point(879, 14);
            this.acc_name.Name = "acc_name";
            this.acc_name.Size = new System.Drawing.Size(0, 63);
            this.acc_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 79);
            this.label3.TabIndex = 5;
            this.label3.Text = "[user]";
            // 
            // EditAcc
            // 
            this.EditAcc.BackColor = System.Drawing.Color.DarkOrange;
            this.EditAcc.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAcc.Location = new System.Drawing.Point(902, 14);
            this.EditAcc.Name = "EditAcc";
            this.EditAcc.Size = new System.Drawing.Size(137, 63);
            this.EditAcc.TabIndex = 6;
            this.EditAcc.Text = "Edit account";
            this.EditAcc.UseVisualStyleBackColor = false;
            this.EditAcc.Click += new System.EventHandler(this.EditAcc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // delete_text
            // 
            this.delete_text.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_text.Location = new System.Drawing.Point(150, 464);
            this.delete_text.Name = "delete_text";
            this.delete_text.Size = new System.Drawing.Size(223, 67);
            this.delete_text.TabIndex = 8;
            this.delete_text.Text = "select tour";
            this.delete_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Detour
            // 
            this.Detour.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detour.Location = new System.Drawing.Point(390, 464);
            this.Detour.Name = "Detour";
            this.Detour.Size = new System.Drawing.Size(142, 58);
            this.Detour.TabIndex = 9;
            this.Detour.Text = "Delete tour";
            this.Detour.UseVisualStyleBackColor = true;
            this.Detour.Click += new System.EventHandler(this.Detour_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-4, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "select tour to delete";
            // 
            // Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Detour);
            this.Controls.Add(this.delete_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.acc_name);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tour_display);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Acc";
            this.Text = "Account ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Acc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tour_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Tour_display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label acc_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox delete_text;
        private System.Windows.Forms.Button Detour;
        private System.Windows.Forms.Label label5;
    }
}