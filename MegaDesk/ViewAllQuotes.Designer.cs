namespace MegaDesk
{
    partial class ViewAllQuotes
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
<<<<<<< Updated upstream
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newQuoteLabelTitle = new System.Windows.Forms.Label();
            this.labelDrawers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
<<<<<<< Updated upstream
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 344);
            this.dataGridView1.TabIndex = 0;
            // 
=======
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // newQuoteLabelTitle
            // 
            this.newQuoteLabelTitle.AutoSize = true;
            this.newQuoteLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteLabelTitle.Location = new System.Drawing.Point(71, 12);
            this.newQuoteLabelTitle.Name = "newQuoteLabelTitle";
            this.newQuoteLabelTitle.Size = new System.Drawing.Size(144, 24);
            this.newQuoteLabelTitle.TabIndex = 2;
            this.newQuoteLabelTitle.Text = "View All Quotes";
            // 
            // labelDrawers
            // 
            this.labelDrawers.AutoSize = true;
            this.labelDrawers.Location = new System.Drawing.Point(72, 36);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Size = new System.Drawing.Size(240, 13);
            this.labelDrawers.TabIndex = 8;
            this.labelDrawers.Text = "You can see all quotes that this app was created.";
            // 
>>>>>>> Stashed changes
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< Updated upstream
=======
            this.Controls.Add(this.labelDrawers);
            this.Controls.Add(this.newQuoteLabelTitle);
            this.Controls.Add(this.pictureBox1);
>>>>>>> Stashed changes
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
<<<<<<< Updated upstream
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label newQuoteLabelTitle;
        private System.Windows.Forms.Label labelDrawers;
>>>>>>> Stashed changes
    }
}