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
        public RealDocumentManager(int accessLevel) { 
            _accessLevel = accessLevel;
        }

        public List<string> GetDocumentList()
        {
            List<string> documents = new List<string>();

            for (int i = 0; i < _accessLevel+1; i++)
            {
                 documents.AddRange(_documents[i]);
            }
            
            return documents;
        }

        public string GetDocument(string documentName)
        {
            string fullPath = System.IO.Path.Combine(DocPath, documentName);
            string content = File.ReadAllText(fullPath);
            string contentEncrypted = ProtectionProxy.Cryptography.Encrypt(content, "abc");
            return contentEncrypted;
            throw new Exception("The method or operation is not implemented.");
        }
    }
}