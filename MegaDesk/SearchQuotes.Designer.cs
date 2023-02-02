namespace MegaDesk
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newQuoteLabelTitle = new System.Windows.Forms.Label();
            this.labelDrawers = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxMaterialSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // newQuoteLabelTitle
            // 
            this.newQuoteLabelTitle.AutoSize = true;
            this.newQuoteLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteLabelTitle.Location = new System.Drawing.Point(71, 12);
            this.newQuoteLabelTitle.Name = "newQuoteLabelTitle";
            this.newQuoteLabelTitle.Size = new System.Drawing.Size(132, 24);
            this.newQuoteLabelTitle.TabIndex = 3;
            this.newQuoteLabelTitle.Text = "Search quotes";
            // 
            // labelDrawers
            // 
            this.labelDrawers.AutoSize = true;
            this.labelDrawers.Location = new System.Drawing.Point(72, 36);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Size = new System.Drawing.Size(328, 13);
            this.labelDrawers.TabIndex = 9;
            this.labelDrawers.Text = "You have the ability to search a quote based on the surface material";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 361);
            this.dataGridView1.TabIndex = 10;
            // 
            // comboBoxMaterialSearch
            // 
            this.comboBoxMaterialSearch.FormattingEnabled = true;
            this.comboBoxMaterialSearch.Location = new System.Drawing.Point(571, 36);
            this.comboBoxMaterialSearch.Name = "comboBoxMaterialSearch";
            this.comboBoxMaterialSearch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterialSearch.TabIndex = 11;
            this.comboBoxMaterialSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterialSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Surface Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMaterialSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDrawers);
            this.Controls.Add(this.newQuoteLabelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label newQuoteLabelTitle;
        private System.Windows.Forms.Label labelDrawers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxMaterialSearch;
        private System.Windows.Forms.Label label1;
    }
}