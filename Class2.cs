using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämninguppgift._3_oop
{
    internal class namn
    {
        private string helnamn;
        private string förnamn;
        private string efternamn;

        public string Förnamm
        {
            get { return förnamn; }

            set { förnamn = value; }
        }

        public string Efternamn
        {
            get { return efternamn; }

            set { efternamn = value; }
        }

        public void Namn()
        {
            helnamn = förnamn + " " + efternamn;
            Console.WriteLine("Hej " + helnamn);
        }
    }
}
