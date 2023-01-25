namespace MegaDesk
{
    partial class MainMenu
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
            this.AddNewQuoteNav = new System.Windows.Forms.Button();
            this.ViewNewQuoteNav = new System.Windows.Forms.Button();
            this.SearchQuotesNav = new System.Windows.Forms.Button();
            this.ExitNav = new System.Windows.Forms.Button();
            this.panelNav = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AddNewQuoteNav
            // 
            this.AddNewQuoteNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.AddNewQuoteNav.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(184)))));
            this.AddNewQuoteNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewQuoteNav.ForeColor = System.Drawing.Color.White;
            this.AddNewQuoteNav.Location = new System.Drawing.Point(76, 61);
            this.AddNewQuoteNav.Name = "AddNewQuoteNav";
            this.AddNewQuoteNav.Size = new System.Drawing.Size(117, 27);
            this.AddNewQuoteNav.TabIndex = 0;
            this.AddNewQuoteNav.Text = "Add New Quote";
            this.AddNewQuoteNav.UseVisualStyleBackColor = false;
            this.AddNewQuoteNav.Click += new System.EventHandler(this.AddNewQuoteNav_Click);
            // 
            // ViewNewQuoteNav
            // 
            this.ViewNewQuoteNav.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ViewNewQuoteNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewNewQuoteNav.Location = new System.Drawing.Point(76, 113);
            this.ViewNewQuoteNav.Name = "ViewNewQuoteNav";
            this.ViewNewQuoteNav.Size = new System.Drawing.Size(117, 23);
            this.ViewNewQuoteNav.TabIndex = 1;
            this.ViewNewQuoteNav.Text = "View New Quote";
            this.ViewNewQuoteNav.UseVisualStyleBackColor = true;
            this.ViewNewQuoteNav.Click += new System.EventHandler(this.ViewNewQuoteNav_Click);
            // 
            // SearchQuotesNav
            // 
            this.SearchQuotesNav.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SearchQuotesNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchQuotesNav.Location = new System.Drawing.Point(76, 160);
            this.SearchQuotesNav.Name = "SearchQuotesNav";
            this.SearchQuotesNav.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchQuotesNav.Size = new System.Drawing.Size(117, 23);
            this.SearchQuotesNav.TabIndex = 2;
            this.SearchQuotesNav.Text = "Search Quotes";
            this.SearchQuotesNav.UseVisualStyleBackColor = true;
            this.SearchQuotesNav.Click += new System.EventHandler(this.SearchQuotesNav_Click);
            // 
            // ExitNav
            // 
            this.ExitNav.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ExitNav.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.ExitNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitNav.Location = new System.Drawing.Point(76, 206);
            this.ExitNav.Name = "ExitNav";
            this.ExitNav.Size = new System.Drawing.Size(117, 23);
            this.ExitNav.TabIndex = 3;
            this.ExitNav.Text = "Exit";
            this.ExitNav.UseVisualStyleBackColor = false;
            this.ExitNav.Click += new System.EventHandler(this.ExitNav_Click);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(275, 299);
            this.panelNav.TabIndex = 17;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(548, 299);
            this.Controls.Add(this.ExitNav);
            this.Controls.Add(this.SearchQuotesNav);
            this.Controls.Add(this.ViewNewQuoteNav);
            this.Controls.Add(this.AddNewQuoteNav);
            this.Controls.Add(this.panelNav);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuoteNav;
        private System.Windows.Forms.Button ViewNewQuoteNav;
        private System.Windows.Forms.Button SearchQuotesNav;
        private System.Windows.Forms.Button ExitNav;
        private System.Windows.Forms.Panel panelNav;
    }
}

