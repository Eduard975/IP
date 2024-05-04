/**************************************************************************
 *                                                                        *
 *  File:        Form1.Designer.cs                                        *
 *  Copyright:   (c) 2008, Florin Leon                                    *
 *  E-mail:      fleon@cs.tuiasi.ro                                       *
 *  Website:     http://eureka.cs.tuiasi.ro/~fleon/lab_ip.htm             *
 *  Description: http://eureka.cs.tuiasi.ro/~fleon                        *
 *               Secret documents application with Protection Proxy.      *
 *               Main form designer (Software Engineering lab 9)          *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/


namespace ProtectionProxy
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.textBoxAccessLevel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxDocs = new System.Windows.Forms.GroupBox();
            this.listBoxDocList = new System.Windows.Forms.ListBox();
            this.groupBoxContent = new System.Windows.Forms.GroupBox();
            this.richTextBoxDocument = new System.Windows.Forms.RichTextBox();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.comboBoxAccessLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNewUser = new System.Windows.Forms.TextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxDocs.SuspendLayout();
            this.groupBoxContent.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(104, 23);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(132, 22);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(104, 55);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(104, 87);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(133, 28);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Intra";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.textBoxAccessLevel);
            this.groupBoxLogin.Controls.Add(this.label3);
            this.groupBoxLogin.Controls.Add(this.textBoxUserName);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Location = new System.Drawing.Point(16, 15);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Size = new System.Drawing.Size(257, 162);
            this.groupBoxLogin.TabIndex = 5;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Autentificare";
            // 
            // textBoxAccessLevel
            // 
            this.textBoxAccessLevel.Location = new System.Drawing.Point(104, 123);
            this.textBoxAccessLevel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAccessLevel.Name = "textBoxAccessLevel";
            this.textBoxAccessLevel.ReadOnly = true;
            this.textBoxAccessLevel.Size = new System.Drawing.Size(132, 22);
            this.textBoxAccessLevel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nivel acces";
            // 
            // groupBoxDocs
            // 
            this.groupBoxDocs.Controls.Add(this.listBoxDocList);
            this.groupBoxDocs.Location = new System.Drawing.Point(281, 15);
            this.groupBoxDocs.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDocs.Name = "groupBoxDocs";
            this.groupBoxDocs.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDocs.Size = new System.Drawing.Size(296, 162);
            this.groupBoxDocs.TabIndex = 6;
            this.groupBoxDocs.TabStop = false;
            this.groupBoxDocs.Text = "Documente disponibile";
            // 
            // listBoxDocList
            // 
            this.listBoxDocList.FormattingEnabled = true;
            this.listBoxDocList.ItemHeight = 16;
            this.listBoxDocList.Location = new System.Drawing.Point(8, 23);
            this.listBoxDocList.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDocList.Name = "listBoxDocList";
            this.listBoxDocList.Size = new System.Drawing.Size(269, 132);
            this.listBoxDocList.TabIndex = 0;
            this.listBoxDocList.SelectedIndexChanged += new System.EventHandler(this.listBoxDocList_SelectedIndexChanged);
            // 
            // groupBoxContent
            // 
            this.groupBoxContent.Controls.Add(this.richTextBoxDocument);
            this.groupBoxContent.Location = new System.Drawing.Point(16, 185);
            this.groupBoxContent.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxContent.Name = "groupBoxContent";
            this.groupBoxContent.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxContent.Size = new System.Drawing.Size(827, 356);
            this.groupBoxContent.TabIndex = 7;
            this.groupBoxContent.TabStop = false;
            this.groupBoxContent.Text = "Continut";
            // 
            // richTextBoxDocument
            // 
            this.richTextBoxDocument.Location = new System.Drawing.Point(16, 23);
            this.richTextBoxDocument.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDocument.Name = "richTextBoxDocument";
            this.richTextBoxDocument.ReadOnly = true;
            this.richTextBoxDocument.Size = new System.Drawing.Size(789, 324);
            this.richTextBoxDocument.TabIndex = 0;
            this.richTextBoxDocument.Text = "";
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.comboBoxAccessLevel);
            this.groupBoxAdmin.Controls.Add(this.label4);
            this.groupBoxAdmin.Controls.Add(this.textBoxNewUser);
            this.groupBoxAdmin.Controls.Add(this.buttonAddNew);
            this.groupBoxAdmin.Controls.Add(this.label5);
            this.groupBoxAdmin.Controls.Add(this.textBoxNewPassword);
            this.groupBoxAdmin.Controls.Add(this.label6);
            this.groupBoxAdmin.Location = new System.Drawing.Point(585, 15);
            this.groupBoxAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAdmin.Size = new System.Drawing.Size(257, 162);
            this.groupBoxAdmin.TabIndex = 8;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Administrator";
            // 
            // comboBoxAccessLevel
            // 
            this.comboBoxAccessLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccessLevel.FormattingEnabled = true;
            this.comboBoxAccessLevel.Items.AddRange(new object[] {
            "Public",
            "Privat",
            "Confidential",
            "Secret"});
            this.comboBoxAccessLevel.Location = new System.Drawing.Point(104, 87);
            this.comboBoxAccessLevel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAccessLevel.Name = "comboBoxAccessLevel";
            this.comboBoxAccessLevel.Size = new System.Drawing.Size(132, 24);
            this.comboBoxAccessLevel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nivel acces";
            // 
            // textBoxNewUser
            // 
            this.textBoxNewUser.Location = new System.Drawing.Point(104, 23);
            this.textBoxNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewUser.Name = "textBoxNewUser";
            this.textBoxNewUser.Size = new System.Drawing.Size(132, 22);
            this.textBoxNewUser.TabIndex = 1;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(104, 127);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(133, 28);
            this.buttonAddNew.TabIndex = 4;
            this.buttonAddNew.Text = "Adauga";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Utilizator";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(104, 55);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxNewPassword.TabIndex = 3;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Parola";
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(32, 549);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(133, 28);
            this.aboutBtn.TabIndex = 9;
            this.aboutBtn.Text = "Despre";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(688, 549);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(133, 28);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "Iesire";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(860, 581);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.groupBoxContent);
            this.Controls.Add(this.groupBoxDocs);
            this.Controls.Add(this.groupBoxLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Drepturi de acces";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxDocs.ResumeLayout(false);
            this.groupBoxContent.ResumeLayout(false);
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxDocs;
        private System.Windows.Forms.TextBox textBoxAccessLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDocList;
        private System.Windows.Forms.GroupBox groupBoxContent;
        private System.Windows.Forms.RichTextBox richTextBoxDocument;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.ComboBox comboBoxAccessLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNewUser;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

