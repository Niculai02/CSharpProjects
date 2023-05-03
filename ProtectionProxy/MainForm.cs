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
            richTextBoxDocument.Text = string.Empty;
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            listBoxDocList.Items.Clear();
            bool success = _proxyDocumentManager.Login(username, password);
            textBoxAccessLevel_TextChanged(sender, e);
            if (success)
            {

                if (username == "admin")
                    groupBoxAdmin.Enabled = true;
                else
                {
                    groupBoxAdmin.Enabled = false;
                    textBoxNewUser.Text = String.Empty;
                    textBoxNewPassword.Text = String.Empty;
                    comboBoxAccessLevel.SelectedIndex = -1;
                }
                List<string> docList = _proxyDocumentManager.GetDocumentList();
                foreach (var doc in docList)
                {
                    listBoxDocList.Items.Add(doc);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listBoxDocList_SelectedIndexChanged(object sender, EventArgs e)
        {   
            richTextBoxDocument.Rtf = _proxyDocumentManager.GetDocument(listBoxDocList.SelectedItem.ToString());
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
             MessageBox.Show(comboBoxAccessLevel.SelectedIndex.ToString());
             _proxyDocumentManager.AddUser(textBoxNewUser.Text, textBoxNewPassword.Text, comboBoxAccessLevel.SelectedIndex);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicatie Laborator 9, Ingineria programarii \nCiobanu Nicu");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBoxAccessLevel_TextChanged(object sender, EventArgs e)
        {

            switch (_proxyDocumentManager.CurrentAccessLevel())
            {
                case 0:
                    textBoxAccessLevel.Text = "Public";
                    break;
                case 1:
                    textBoxAccessLevel.Text = "Privat";
                    break;
                case 2:
                    textBoxAccessLevel.Text = "Confidential";
                    break;
                case 3:
                    textBoxAccessLevel.Text = "Secret";
                    break;
                case -1:
                    textBoxAccessLevel.Text = "Admin";
                    break;
                default:
                    break;
            }
        }

        private void textBoxNewUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}