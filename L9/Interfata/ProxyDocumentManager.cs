/**************************************************************************
 *                                                                        *
 *  File:        DocumentManager.cs                                       *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Secret documents application with Protection Proxy.      *
 *               The Protection Proxy (Software Engineering lab 9)        *
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
using System.IO;
using System.Windows.Forms;

namespace ProtectionProxy
{
    public class ProxyDocumentManager : IDocumentManager
    {
        private RealDocumentManager _realDocumentManager;
        private List<User> _users;
        private User _currentUser;
        private List<string> _levels;
        private const string Path = "Secure\\";

        public struct User
        {
            public readonly string Name;
            public readonly string PassHash;
            public readonly int AccessLevel;

            public User(string name, string passHash, int accessLevel)
            {
                Name = name;
                PassHash = passHash;
                AccessLevel = accessLevel;
            }

            public override string ToString()
            {
                return Name + "\t" + PassHash + "\t" + AccessLevel.ToString();
            }
        }

        public ProxyDocumentManager()
        {
            try
            {
                _levels = new List<string>();
                StreamReader sr = new StreamReader(Path + "niveluri.txt");
                string[] lvls = sr.ReadToEnd().Split(" \t\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();

                for (int i = 0; i < lvls.Length; i++)
                    _levels.Add(lvls[i]);

                _users = new List<User>();
                sr = new StreamReader(Path + "utilizatori.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] toks = line.Split('\t');
                    User user = new User(toks[0], toks[1], Convert.ToInt32(toks[2]));
                    _users.Add(user);
                }
                sr.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public List<string> Levels()
        {
            return _levels;
        }

        public List<string> GetDocumentList()
        {
            _realDocumentManager = new RealDocumentManager(_currentUser.AccessLevel);

            return _realDocumentManager.GetDocumentList();
        }

        public string GetDocument(string documentName)
        {
            // documentul primit trebuie decriptat inainte de a-i fi trimis clientului
            _realDocumentManager = new RealDocumentManager(_currentUser.AccessLevel);

            string documentContent = _realDocumentManager.GetDocument(documentName);

            documentContent = Cryptography.Decrypt(documentContent, documentName);

            return documentContent;
        }

        public int CurrentAccessLevel() {
            return _currentUser.AccessLevel;
        }

        public bool Login(string username, string password)
        {
            User myUser =  _users.Find(user => user.Name == username);
            if (myUser.PassHash == Cryptography.HashString(password)) 
            {
                _currentUser = myUser;
                return true;
            }
            return false;
        }

        public void addUser(string name, string password, int accessLevel) 
        {
            User newUser = new User(name, Cryptography.HashString(password), accessLevel);
            _users.Add(newUser);
            StreamWriter sw = new StreamWriter(Path + "utilizatori.txt", true);
            sw.WriteLine(newUser.ToString());
            sw.Close();
        }
    }
}