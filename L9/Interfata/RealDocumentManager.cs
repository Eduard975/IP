/**************************************************************************
 *                                                                        *
 *  File:        DocumentManager.cs                                       *
 *  Copyright:   (c) 2008-2019, Florin Leon                               *
 *  E-mail:      florin.leon@tuiasi.ro                                    *
 *  Website:     http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Secret documents application with Protection Proxy.      *
 *               The real subject (Software Engineering lab 9)            *
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
    public class RealDocumentManager : IDocumentManager
    {
        private static List<List<string>> _documents;
        private int _accessLevel;
        private const string Path = "Secure\\", DocPath = "Secure\\Documente\\";

        static RealDocumentManager()
        {
            // constructorul static este apelat automat o singura data inainte de prima instantiere a clasei sau inainte de folosirea campurilor statice
            // prin urmare, lista de documente este citita o singura data si de fiecate data cand se logheaza un utilizator
            // _documents este o lista de liste: pentru fiecare nivel de acces este retinuta lista de documente corespunzatoare nivelului respectiv

            try
            {
                StreamReader sr = new StreamReader(Path + "drepturi.txt");
                string[] lines = sr.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                sr.Close();

                int numberOfLevels = lines.Length;

                _documents = new List<List<string>>(numberOfLevels);
                for (int i = 0; i < numberOfLevels; i++)
                    _documents.Add(new List<string>());

                for (int i = 0; i < numberOfLevels; i++)
                {
                    string[] files = lines[i].Split();
                    _documents[i].AddRange(files);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public RealDocumentManager(int accessLevel)
        {
            _accessLevel = accessLevel;
        }
        public List<string> GetDocumentList()
        {
            // trebuie returnata lista de documente corespunzatoare nivelului de acces curent si tuturor nivelurilor anterioare
            // de exemplu, daca nivelul de acces este "private", se returneaza o lista cu documentele de pe nivelurile "public" si "private"
            List<string> docList = new List<string>();

            for (int i = 0; i <= _accessLevel; ++i) {
                _documents[i].ForEach(doc => docList.Add(doc));
            }

            return docList;
        }

        public string GetDocument(string documentName)
        {
            // se returneaza continutul efectiv al documentului
            // prespupunand ca aplicatia se poate extinde astfel incat ProxyDocumentManager si RealDocumentManager 
            // sa fie pe masini diferite, documentul se cripteaza inainte de trimitere
            StreamReader sr = new StreamReader(DocPath + documentName);
            string documentContent = sr.ReadToEnd();
            documentContent = Cryptography.Encrypt(documentContent, documentName);
            sr.Close();
            return documentContent;
        }
    }
}