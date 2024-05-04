/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Secret documents application with Protection Proxy.      *
 *               Main form (Software Engineering lab 9)                   *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProtectionProxy
{
    public partial class MainForm : Form
    {
        private ProxyDocumentManager _proxyDocumentManager;

        public MainForm()
        {
            InitializeComponent();
            groupBoxAdmin.Enabled = false;

            _proxyDocumentManager = new ProxyDocumentManager();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (_proxyDocumentManager.Login(textBoxUserName.Text, textBoxPassword.Text))
            {
                int accLevel = _proxyDocumentManager.CurrentAccessLevel();
                if (accLevel == -1)
                {
                    textBoxAccessLevel.Text = "Admin";
                    groupBoxAdmin.Enabled = true;
                }
                else
                {
                    listBoxDocList.Items.Clear();
                    groupBoxAdmin.Enabled = false;
                    List<string> docList = _proxyDocumentManager.GetDocumentList();
                    docList.ForEach(doc => listBoxDocList.Items.Add(doc));
                    textBoxAccessLevel.Text = _proxyDocumentManager.Levels()[accLevel];
                }
            }
            else
            {
                MessageBox.Show("Utilizator sau parola inexistenta", "Eroare Autentificare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            _proxyDocumentManager.addUser(textBoxNewUser.Text, textBoxNewPassword.Text, comboBoxAccessLevel.SelectedIndex);
        }

        private void listBoxDocList_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxDocument.Rtf = _proxyDocumentManager.GetDocument(listBoxDocList.SelectedItem.ToString());
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatie Proxy\nPetrisor Eduard-Gabriel\n1311A", "Laborarot 9 - IP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}