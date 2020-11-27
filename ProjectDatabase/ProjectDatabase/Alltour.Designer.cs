namespace ProjectDatabase
{
    partial class Alltour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alltour));
            this.label1 = new System.Windows.Forms.Label();
            this.tour = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addtour = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plan your travel!";
            // 
            // tour
            // 
            this.tour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tour.Location = new System.Drawing.Point(2, 92);
            this.tour.Name = "tour";
            this.tour.RowHeadersWidth = 51;
            this.tour.RowTemplate.Height = 24;
            this.tour.Size = new System.Drawing.Size(882, 346);
            this.tour.TabIndex = 1;
            this.tour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tour_CellContentClick);
            this.tour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tour_CellContentClick);
            this.tour.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tour_CellContentClick);
            // 
            // show
            // 
            this.show.Enabled = false;
            this.show.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.Location = new System.Drawing.Point(295, 464);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(184, 45);
            this.show.TabIndex = 2;
            this.show.TextChanged += new System.EventHandler(this.show_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select your tour";
            // 
            // addtour
            // 
            this.addtour.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.addtour.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addtour.Location = new System.Drawing.Point(736, 447);
            this.addtour.Name = "addtour";
            this.addtour.Size = new System.Drawing.Size(148, 76);
            this.addtour.TabIndex = 4;
            this.addtour.Text = "Add";
            this.addtour.UseVisualStyleBackColor = false;
            this.addtour.Click += new System.EventHandler(this.addtour_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(612, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 95);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Alltour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addtour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.tour);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Alltour";
            this.Text = "Alltour";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Alltour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tour;
        private System.Windows.Forms.TextBox show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addtour;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}