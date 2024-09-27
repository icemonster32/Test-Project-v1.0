namespace Test_Project_v1._0
{
    partial class Login
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
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            loginBtn = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            showPass = new CheckBox();
            label4 = new Label();
            exit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Cursor = Cursors.IBeam;
            usernameTxt.Font = new Font("Segoe UI", 12F);
            usernameTxt.Location = new Point(294, 172);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.ShortcutsEnabled = false;
            usernameTxt.Size = new Size(275, 29);
            usernameTxt.TabIndex = 0;
            usernameTxt.KeyPress += usernameTxt_KeyPress_1;
            // 
            // passwordTxt
            // 
            passwordTxt.Cursor = Cursors.IBeam;
            passwordTxt.Font = new Font("Segoe UI", 12F);
            passwordTxt.Location = new Point(294, 234);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.ShortcutsEnabled = false;
            passwordTxt.Size = new Size(275, 29);
            passwordTxt.TabIndex = 1;
            passwordTxt.KeyPress += passwordTxt_KeyPress_1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.Highlight;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(294, 317);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(275, 30);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 461);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(11, 439);
            label5.Name = "label5";
            label5.Size = new Size(105, 12);
            label5.TabIndex = 9;
            label5.Text = "Created by: Nico Galinato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 67);
            label1.Name = "label1";
            label1.Size = new Size(75, 30);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(294, 149);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(294, 211);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Cursor = Cursors.Hand;
            showPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPass.Location = new Point(451, 270);
            showPass.Name = "showPass";
            showPass.Size = new Size(118, 21);
            showPass.TabIndex = 7;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(502, 440);
            label4.Name = "label4";
            label4.Size = new Size(70, 12);
            label4.TabIndex = 8;
            label4.Text = "Test Project V1.0";
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderColor = Color.Silver;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(543, 1);
            exit.Margin = new Padding(0);
            exit.Name = "exit";
            exit.Size = new Size(40, 35);
            exit.TabIndex = 10;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(584, 461);
            Controls.Add(exit);
            Controls.Add(label4);
            Controls.Add(showPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Button loginBtn;
        private Panel panel1;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox showPass;
        private Label label4;
        private Button exit;
    }
}
