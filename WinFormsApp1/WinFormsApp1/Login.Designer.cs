namespace WinFormsApp1
{
    partial class Login
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
            BasicPanel = new Panel();
            InfoPanel = new Panel();
            label3 = new Label();
            label1 = new Label();
            LogoPanel = new Panel();
            LoginInfoPanel = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            BtnCancel = new Button();
            BtnAgree = new Button();
            panel1 = new Panel();
            txtboxPass = new TextBox();
            txtboxID = new TextBox();
            lblPass = new Label();
            lblID = new Label();
            BasicPanel.SuspendLayout();
            InfoPanel.SuspendLayout();
            LoginInfoPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BasicPanel
            // 
            BasicPanel.Controls.Add(InfoPanel);
            BasicPanel.Controls.Add(LogoPanel);
            BasicPanel.Controls.Add(LoginInfoPanel);
            BasicPanel.Dock = DockStyle.Fill;
            BasicPanel.Location = new Point(0, 0);
            BasicPanel.Name = "BasicPanel";
            BasicPanel.Size = new Size(800, 561);
            BasicPanel.TabIndex = 0;
            // 
            // InfoPanel
            // 
            InfoPanel.Controls.Add(label3);
            InfoPanel.Controls.Add(label1);
            InfoPanel.Dock = DockStyle.Bottom;
            InfoPanel.Location = new Point(0, 523);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(303, 38);
            InfoPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 11);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // LogoPanel
            // 
            LogoPanel.Dock = DockStyle.Fill;
            LogoPanel.Location = new Point(0, 0);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Size = new Size(303, 561);
            LogoPanel.TabIndex = 1;
            // 
            // LoginInfoPanel
            // 
            LoginInfoPanel.Controls.Add(panel2);
            LoginInfoPanel.Controls.Add(panel1);
            LoginInfoPanel.Dock = DockStyle.Right;
            LoginInfoPanel.Location = new Point(303, 0);
            LoginInfoPanel.Name = "LoginInfoPanel";
            LoginInfoPanel.Size = new Size(497, 561);
            LoginInfoPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BtnCancel);
            panel2.Controls.Add(BtnAgree);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 523);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 38);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(392, 7);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 0;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAgree
            // 
            BtnAgree.Location = new Point(311, 7);
            BtnAgree.Name = "BtnAgree";
            BtnAgree.Size = new Size(75, 23);
            BtnAgree.TabIndex = 1;
            BtnAgree.Text = "확인";
            BtnAgree.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtboxPass);
            panel1.Controls.Add(txtboxID);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(lblID);
            panel1.Location = new Point(0, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 129);
            panel1.TabIndex = 8;
            // 
            // txtboxPass
            // 
            txtboxPass.Location = new Point(136, 75);
            txtboxPass.Name = "txtboxPass";
            txtboxPass.Size = new Size(223, 23);
            txtboxPass.TabIndex = 3;
            // 
            // txtboxID
            // 
            txtboxID.Location = new Point(136, 38);
            txtboxID.Name = "txtboxID";
            txtboxID.Size = new Size(223, 23);
            txtboxID.TabIndex = 2;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(75, 78);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(55, 15);
            lblPass.TabIndex = 5;
            lblPass.Text = "비밀번호";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(85, 41);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 15);
            lblID.TabIndex = 4;
            lblID.Text = "사번";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(BasicPanel);
            MinimumSize = new Size(800, 600);
            Name = "Login";
            Text = "Login";
            BasicPanel.ResumeLayout(false);
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            LoginInfoPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BasicPanel;
        private Panel InfoPanel;
        private Panel LogoPanel;
        private Panel LoginInfoPanel;
        private Panel panel1;
        private TextBox txtboxPass;
        private TextBox txtboxID;
        private Label lblPass;
        private Label lblID;
        private Panel panel2;
        private Button BtnCancel;
        private Button BtnAgree;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}