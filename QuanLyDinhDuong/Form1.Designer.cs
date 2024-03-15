namespace Test_1
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBody1 = new System.Windows.Forms.Panel();
            this.ibHome = new FontAwesome.Sharp.IconButton();
            this.Settings = new FontAwesome.Sharp.IconButton();
            this.WorkOut = new FontAwesome.Sharp.IconButton();
            this.Chart = new FontAwesome.Sharp.IconButton();
            this.AddFood = new FontAwesome.Sharp.IconButton();
            this.MacroSplit = new FontAwesome.Sharp.IconButton();
            this.Caculate = new FontAwesome.Sharp.IconButton();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.Settings);
            this.panelMenu.Controls.Add(this.WorkOut);
            this.panelMenu.Controls.Add(this.Chart);
            this.panelMenu.Controls.Add(this.AddFood);
            this.panelMenu.Controls.Add(this.MacroSplit);
            this.panelMenu.Controls.Add(this.Caculate);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(140, 637);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.imageLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(140, 87);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.ibHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(140, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 77);
            this.panel1.TabIndex = 1;
            // 
            // panelBody1
            // 
            this.panelBody1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody1.Location = new System.Drawing.Point(140, 77);
            this.panelBody1.Margin = new System.Windows.Forms.Padding(2);
            this.panelBody1.Name = "panelBody1";
            this.panelBody1.Size = new System.Drawing.Size(973, 560);
            this.panelBody1.TabIndex = 2;
            this.panelBody1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBody1_Paint);
            // 
            // ibHome
            // 
            this.ibHome.FlatAppearance.BorderSize = 0;
            this.ibHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibHome.ForeColor = System.Drawing.SystemColors.Info;
            this.ibHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ibHome.IconColor = System.Drawing.Color.LightSalmon;
            this.ibHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibHome.IconSize = 50;
            this.ibHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHome.Location = new System.Drawing.Point(4, 11);
            this.ibHome.Margin = new System.Windows.Forms.Padding(2);
            this.ibHome.Name = "ibHome";
            this.ibHome.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.ibHome.Size = new System.Drawing.Size(967, 60);
            this.ibHome.TabIndex = 3;
            this.ibHome.Text = "Home";
            this.ibHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibHome.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.SystemColors.Info;
            this.Settings.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            this.Settings.IconColor = System.Drawing.Color.LightSalmon;
            this.Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settings.IconSize = 32;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 352);
            this.Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.Settings.Size = new System.Drawing.Size(140, 53);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // WorkOut
            // 
            this.WorkOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkOut.FlatAppearance.BorderSize = 0;
            this.WorkOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkOut.ForeColor = System.Drawing.SystemColors.Info;
            this.WorkOut.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            this.WorkOut.IconColor = System.Drawing.Color.LightSalmon;
            this.WorkOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WorkOut.IconSize = 32;
            this.WorkOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkOut.Location = new System.Drawing.Point(0, 299);
            this.WorkOut.Margin = new System.Windows.Forms.Padding(2);
            this.WorkOut.Name = "WorkOut";
            this.WorkOut.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.WorkOut.Size = new System.Drawing.Size(140, 53);
            this.WorkOut.TabIndex = 5;
            this.WorkOut.Text = "WorkOut";
            this.WorkOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.WorkOut.UseVisualStyleBackColor = true;
            // 
            // Chart
            // 
            this.Chart.Dock = System.Windows.Forms.DockStyle.Top;
            this.Chart.FlatAppearance.BorderSize = 0;
            this.Chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chart.ForeColor = System.Drawing.SystemColors.Info;
            this.Chart.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.Chart.IconColor = System.Drawing.Color.LightSalmon;
            this.Chart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Chart.IconSize = 32;
            this.Chart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Chart.Location = new System.Drawing.Point(0, 246);
            this.Chart.Margin = new System.Windows.Forms.Padding(2);
            this.Chart.Name = "Chart";
            this.Chart.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.Chart.Size = new System.Drawing.Size(140, 53);
            this.Chart.TabIndex = 4;
            this.Chart.Text = "Chart";
            this.Chart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Chart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Chart.UseVisualStyleBackColor = true;
            // 
            // AddFood
            // 
            this.AddFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddFood.FlatAppearance.BorderSize = 0;
            this.AddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFood.ForeColor = System.Drawing.SystemColors.Info;
            this.AddFood.IconChar = FontAwesome.Sharp.IconChar.Paragraph;
            this.AddFood.IconColor = System.Drawing.Color.LightSalmon;
            this.AddFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddFood.IconSize = 32;
            this.AddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddFood.Location = new System.Drawing.Point(0, 193);
            this.AddFood.Margin = new System.Windows.Forms.Padding(2);
            this.AddFood.Name = "AddFood";
            this.AddFood.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.AddFood.Size = new System.Drawing.Size(140, 53);
            this.AddFood.TabIndex = 3;
            this.AddFood.Text = "AddFood";
            this.AddFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddFood.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddFood.UseVisualStyleBackColor = true;
            // 
            // MacroSplit
            // 
            this.MacroSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.MacroSplit.FlatAppearance.BorderSize = 0;
            this.MacroSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MacroSplit.ForeColor = System.Drawing.SystemColors.Info;
            this.MacroSplit.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.MacroSplit.IconColor = System.Drawing.Color.LightSalmon;
            this.MacroSplit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MacroSplit.IconSize = 50;
            this.MacroSplit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MacroSplit.Location = new System.Drawing.Point(0, 140);
            this.MacroSplit.Margin = new System.Windows.Forms.Padding(2);
            this.MacroSplit.Name = "MacroSplit";
            this.MacroSplit.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.MacroSplit.Size = new System.Drawing.Size(140, 53);
            this.MacroSplit.TabIndex = 2;
            this.MacroSplit.Text = "MacroSplit";
            this.MacroSplit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MacroSplit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MacroSplit.UseVisualStyleBackColor = true;
            this.MacroSplit.Click += new System.EventHandler(this.MacroSplit_Click);
            // 
            // Caculate
            // 
            this.Caculate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Caculate.FlatAppearance.BorderSize = 0;
            this.Caculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Caculate.ForeColor = System.Drawing.SystemColors.Info;
            this.Caculate.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            this.Caculate.IconColor = System.Drawing.Color.LightSalmon;
            this.Caculate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Caculate.IconSize = 50;
            this.Caculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Caculate.Location = new System.Drawing.Point(0, 87);
            this.Caculate.Margin = new System.Windows.Forms.Padding(2);
            this.Caculate.Name = "Caculate";
            this.Caculate.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.Caculate.Size = new System.Drawing.Size(140, 53);
            this.Caculate.TabIndex = 1;
            this.Caculate.Text = "Caculate";
            this.Caculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Caculate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Caculate.UseVisualStyleBackColor = true;
            this.Caculate.Click += new System.EventHandler(this.Caculate_Click);
            // 
            // imageLogo
            // 
            this.imageLogo.Image = global::Test_1.Properties.Resources.logo_nike_inkythuatso_2_01_04_15_42_44__1_;
            this.imageLogo.Location = new System.Drawing.Point(23, 11);
            this.imageLogo.Margin = new System.Windows.Forms.Padding(2);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(86, 58);
            this.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageLogo.TabIndex = 1;
            this.imageLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 637);
            this.Controls.Add(this.panelBody1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox imageLogo;
        private FontAwesome.Sharp.IconButton Caculate;
        private FontAwesome.Sharp.IconButton Settings;
        private FontAwesome.Sharp.IconButton WorkOut;
        private FontAwesome.Sharp.IconButton Chart;
        private FontAwesome.Sharp.IconButton AddFood;
        private FontAwesome.Sharp.IconButton MacroSplit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBody1;
        private FontAwesome.Sharp.IconButton ibHome;
    }
}

