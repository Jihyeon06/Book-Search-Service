namespace Yeoju_Frist_High_School_Library_Search
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideBar_panel = new System.Windows.Forms.Panel();
            this.SideSelect_panel = new System.Windows.Forms.Panel();
            this.ManagerOnlyPage_button = new System.Windows.Forms.Button();
            this.BookSearchPage_button = new System.Windows.Forms.Button();
            this.MainPage_button = new System.Windows.Forms.Button();
            this.SideTop_banner = new System.Windows.Forms.Panel();
            this.SideBar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar_panel
            // 
            this.SideBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SideBar_panel.Controls.Add(this.SideSelect_panel);
            this.SideBar_panel.Controls.Add(this.ManagerOnlyPage_button);
            this.SideBar_panel.Controls.Add(this.BookSearchPage_button);
            this.SideBar_panel.Controls.Add(this.MainPage_button);
            this.SideBar_panel.Controls.Add(this.SideTop_banner);
            this.SideBar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar_panel.Location = new System.Drawing.Point(0, 0);
            this.SideBar_panel.Name = "SideBar_panel";
            this.SideBar_panel.Size = new System.Drawing.Size(250, 800);
            this.SideBar_panel.TabIndex = 0;
            // 
            // SideSelect_panel
            // 
            this.SideSelect_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(65)))), ((int)(((byte)(209)))));
            this.SideSelect_panel.Location = new System.Drawing.Point(-1, 152);
            this.SideSelect_panel.Name = "SideSelect_panel";
            this.SideSelect_panel.Size = new System.Drawing.Size(10, 41);
            this.SideSelect_panel.TabIndex = 4;
            // 
            // ManagerOnlyPage_button
            // 
            this.ManagerOnlyPage_button.BackColor = System.Drawing.Color.Transparent;
            this.ManagerOnlyPage_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.ManagerOnlyPage_button.FlatAppearance.BorderSize = 0;
            this.ManagerOnlyPage_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.ManagerOnlyPage_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.ManagerOnlyPage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerOnlyPage_button.ForeColor = System.Drawing.Color.Lavender;
            this.ManagerOnlyPage_button.Image = global::Yeoju_Frist_High_School_Library_Search.Properties.Resources.white_lock;
            this.ManagerOnlyPage_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerOnlyPage_button.Location = new System.Drawing.Point(0, 244);
            this.ManagerOnlyPage_button.Name = "ManagerOnlyPage_button";
            this.ManagerOnlyPage_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ManagerOnlyPage_button.Size = new System.Drawing.Size(250, 40);
            this.ManagerOnlyPage_button.TabIndex = 3;
            this.ManagerOnlyPage_button.Text = " 관리자 전용 페이지";
            this.ManagerOnlyPage_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManagerOnlyPage_button.UseVisualStyleBackColor = false;
            this.ManagerOnlyPage_button.Click += new System.EventHandler(this.ManagerOnlyPage_button_Click);
            // 
            // BookSearchPage_button
            // 
            this.BookSearchPage_button.BackColor = System.Drawing.Color.Transparent;
            this.BookSearchPage_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.BookSearchPage_button.FlatAppearance.BorderSize = 0;
            this.BookSearchPage_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.BookSearchPage_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.BookSearchPage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookSearchPage_button.ForeColor = System.Drawing.Color.Lavender;
            this.BookSearchPage_button.Image = global::Yeoju_Frist_High_School_Library_Search.Properties.Resources.white_book;
            this.BookSearchPage_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookSearchPage_button.Location = new System.Drawing.Point(0, 198);
            this.BookSearchPage_button.Name = "BookSearchPage_button";
            this.BookSearchPage_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BookSearchPage_button.Size = new System.Drawing.Size(250, 40);
            this.BookSearchPage_button.TabIndex = 2;
            this.BookSearchPage_button.Text = " 도서 검색 페이지";
            this.BookSearchPage_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BookSearchPage_button.UseVisualStyleBackColor = false;
            this.BookSearchPage_button.Click += new System.EventHandler(this.BookSearchPage_button_Click);
            // 
            // MainPage_button
            // 
            this.MainPage_button.BackColor = System.Drawing.Color.Transparent;
            this.MainPage_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.MainPage_button.FlatAppearance.BorderSize = 0;
            this.MainPage_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.MainPage_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(3)))), ((int)(((byte)(17)))), ((int)(((byte)(0)))));
            this.MainPage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPage_button.ForeColor = System.Drawing.Color.Lavender;
            this.MainPage_button.Image = global::Yeoju_Frist_High_School_Library_Search.Properties.Resources.white_home;
            this.MainPage_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainPage_button.Location = new System.Drawing.Point(0, 152);
            this.MainPage_button.Name = "MainPage_button";
            this.MainPage_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MainPage_button.Size = new System.Drawing.Size(250, 40);
            this.MainPage_button.TabIndex = 1;
            this.MainPage_button.Text = " 메인 페이지";
            this.MainPage_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MainPage_button.UseVisualStyleBackColor = false;
            this.MainPage_button.Click += new System.EventHandler(this.MainPage_button_Click);
            // 
            // SideTop_banner
            // 
            this.SideTop_banner.BackgroundImage = global::Yeoju_Frist_High_School_Library_Search.Properties.Resources.banner;
            this.SideTop_banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideTop_banner.Location = new System.Drawing.Point(0, 0);
            this.SideTop_banner.Name = "SideTop_banner";
            this.SideTop_banner.Size = new System.Drawing.Size(250, 135);
            this.SideTop_banner.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.SideBar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SideBar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SideBar_panel;
        private Button MainPage_button;
        private Panel SideTop_banner;
        private Button ManagerOnlyPage_button;
        private Button BookSearchPage_button;
        private Panel SideSelect_panel;
    }
}