namespace MegaDesk
{
    partial class AddQuote
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
            this.newQuoteLabelTitle = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.labelDeskWidth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.labelDrawers = new System.Windows.Forms.Label();
            this.numericUpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.labelRush = new System.Windows.Forms.Label();
            this.comboBoxRush = new System.Windows.Forms.ComboBox();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.buttonCancelQuote = new System.Windows.Forms.Button();
            this.buttonSaveQuote = new System.Windows.Forms.Button();
            this.panelAddNewQuoteCTAs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).BeginInit();
            this.panelAddNewQuoteCTAs.SuspendLayout();
            this.SuspendLayout();
            // 
            // newQuoteLabelTitle
            // 
            this.newQuoteLabelTitle.AutoSize = true;
            this.newQuoteLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuoteLabelTitle.Location = new System.Drawing.Point(289, 62);
            this.newQuoteLabelTitle.Name = "newQuoteLabelTitle";
            this.newQuoteLabelTitle.Size = new System.Drawing.Size(196, 24);
            this.newQuoteLabelTitle.TabIndex = 0;
            this.newQuoteLabelTitle.Text = "Add New Quote Form";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(110, 136);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(82, 13);
            this.labelCustomer.TabIndex = 1;
            this.labelCustomer.Text = "Customer Name";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(216, 133);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(172, 20);
            this.textBoxCustomer.TabIndex = 2;
            // 
            // labelDeskWidth
            // 
            this.labelDeskWidth.AutoSize = true;
            this.labelDeskWidth.Location = new System.Drawing.Point(110, 182);
            this.labelDeskWidth.Name = "labelDeskWidth";
            this.labelDeskWidth.Size = new System.Drawing.Size(100, 13);
            this.labelDeskWidth.TabIndex = 3;
            this.labelDeskWidth.Text = "Desk width (inches)";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(216, 180);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownWidth.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desk depth (inches)";
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Location = new System.Drawing.Point(216, 228);
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownDepth.TabIndex = 6;
            // 
            // labelDrawers
            // 
            this.labelDrawers.AutoSize = true;
            this.labelDrawers.Location = new System.Drawing.Point(422, 136);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Size = new System.Drawing.Size(103, 13);
            this.labelDrawers.TabIndex = 7;
            this.labelDrawers.Text = "Numbers of Drawers";
            // 
            // numericUpDownDrawers
            // 
            this.numericUpDownDrawers.Location = new System.Drawing.Point(531, 134);
            this.numericUpDownDrawers.Name = "numericUpDownDrawers";
            this.numericUpDownDrawers.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDrawers.TabIndex = 8;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(425, 181);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(84, 13);
            this.labelMaterial.TabIndex = 9;
            this.labelMaterial.Text = "Surface Material";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(530, 178);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaterial.TabIndex = 10;
            // 
            // labelRush
            // 
            this.labelRush.AutoSize = true;
            this.labelRush.Location = new System.Drawing.Point(428, 229);
            this.labelRush.Name = "labelRush";
            this.labelRush.Size = new System.Drawing.Size(57, 13);
            this.labelRush.TabIndex = 11;
            this.labelRush.Text = "Rush days";
            // 
            // comboBoxRush
            // 
            this.comboBoxRush.FormattingEnabled = true;
            this.comboBoxRush.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.comboBoxRush.Location = new System.Drawing.Point(530, 228);
            this.comboBoxRush.Name = "comboBoxRush";
            this.comboBoxRush.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRush.TabIndex = 12;
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Location = new System.Drawing.Point(584, 35);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCurrentDate.Size = new System.Drawing.Size(67, 13);
            this.labelCurrentDate.TabIndex = 15;
            this.labelCurrentDate.Text = "Current Date";
            this.labelCurrentDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCancelQuote
            // 
            this.buttonCancelQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.buttonCancelQuote.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCancelQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelQuote.Location = new System.Drawing.Point(400, 39);
            this.buttonCancelQuote.Name = "buttonCancelQuote";
            this.buttonCancelQuote.Size = new System.Drawing.Size(109, 23);
            this.buttonCancelQuote.TabIndex = 14;
            this.buttonCancelQuote.Text = "Cancel Quote";
            this.buttonCancelQuote.UseVisualStyleBackColor = false;
            this.buttonCancelQuote.Click += new System.EventHandler(this.buttonCancelQuote_Click);
            // 
            // buttonSaveQuote
            // 
            this.buttonSaveQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.buttonSaveQuote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.buttonSaveQuote.FlatAppearance.BorderSize = 2;
            this.buttonSaveQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveQuote.ForeColor = System.Drawing.Color.White;
            this.buttonSaveQuote.Location = new System.Drawing.Point(239, 39);
            this.buttonSaveQuote.Name = "buttonSaveQuote";
            this.buttonSaveQuote.Size = new System.Drawing.Size(121, 23);
            this.buttonSaveQuote.TabIndex = 13;
            this.buttonSaveQuote.Text = "Save Quote";
            this.buttonSaveQuote.UseVisualStyleBackColor = false;
            this.buttonSaveQuote.Click += new System.EventHandler(this.buttonSaveQuote_Click);
            // 
            // panelAddNewQuoteCTAs
            // 
            this.panelAddNewQuoteCTAs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAddNewQuoteCTAs.Controls.Add(this.buttonSaveQuote);
            this.panelAddNewQuoteCTAs.Controls.Add(this.buttonCancelQuote);
            this.panelAddNewQuoteCTAs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAddNewQuoteCTAs.Location = new System.Drawing.Point(0, 350);
            this.panelAddNewQuoteCTAs.Name = "panelAddNewQuoteCTAs";
            this.panelAddNewQuoteCTAs.Size = new System.Drawing.Size(800, 100);
            this.panelAddNewQuoteCTAs.TabIndex = 16;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAddNewQuoteCTAs);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.comboBoxRush);
            this.Controls.Add(this.labelRush);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.numericUpDownDrawers);
            this.Controls.Add(this.labelDrawers);
            this.Controls.Add(this.numericUpDownDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.labelDeskWidth);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.newQuoteLabelTitle);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).EndInit();
            this.panelAddNewQuoteCTAs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newQuoteLabelTitle;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.Label labelDeskWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label labelDrawers;
        private System.Windows.Forms.NumericUpDown numericUpDownDrawers;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label labelRush;
        private System.Windows.Forms.ComboBox comboBoxRush;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Button buttonCancelQuote;
        private System.Windows.Forms.Button buttonSaveQuote;
        private System.Windows.Forms.Panel panelAddNewQuoteCTAs;
    }
}