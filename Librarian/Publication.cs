using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Librarian
{
    public enum PublicationType
    {
        General, Book, Article, ConferencePaper
    };



    class Publication
    {
        static Dictionary<string, string> Formats = new Dictionary<string, string>();
        static bool ReadFormats(string formatFile)
        {
            try
            {
                string[] z = File.ReadAllLines(formatFile);
                string key = "";
                string val = "";
                string c;
                int st = 0;
                foreach (string s in z)
                {
                    c = s.Trim();
                    switch (s)
                    {
                        case "<format>":
                            st = 1;
                            break;
                        case "</format>":
                            Formats.Add(key, val);
                            st = 0;
                            break;
                        case "<fmtstring>":
                            st = 2;
                            break;
                        case "</fmtstring>":
                            st = 1;
                            break;
                        case "<pubtype>":
                            st = 3;
                            break;
                        case "</ pubtype>":
                            st = 1;
                            break;
                        default:
                            switch (st)
                            {
                                case 1:
                                    key = c;
                                    break;
                                case 2:
                                    val = c;
                                    break;
                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public string Title = "";
        public string Author = "";
        public string Publisher = "";
        public int Year = 0;
        public PublicationType PubType = PublicationType.General;
        public string ToString(string fmt = "")
        {
            string res = "";
            switch (fmt)
            {
                case "ГОСТ":
                    res = "...";
                    break;
                default:
                    res = Author + " " + Title + ". – " + Publisher + ", " + Year.ToString();
                    break;

            }

            return res;
        }
        public override string ToString()
        {
            return ToString("");
        }
    }
    class JournalArticle : Publication
    {
        public string JournalTitle = "";
        public bool Scopus = false;
        public bool WoS = false;
        public bool RINC = false;
        public int Number = 0;
        public int Vol = 0;
        public int StartPage = 0;
        public int EndPage = 0;
    }
}
