using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaStormProje
{
    class Firma
    {
        public static int firmaID;
        private string firmaAdi;
        private string firmaCeo;
        private string firmaEposta;
        private string firma_telefon;
        private string sifre;


        public string getFirmaAdi
        {
            get { return firmaAdi; }
            set { firmaAdi = value; }
        }
        public string getFirmaCeo
        {
            get { return firmaCeo; }
            set { firmaCeo = value; }
        }
        public string getFirmaEposta
        {
            get { return firmaEposta; }
            set { firmaEposta = value; }
        }
        public string getFirmaTelefon
        {
            get { return firma_telefon; }
            set { firma_telefon = value; }
        }
        public string getFirmaSifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

    }
}
