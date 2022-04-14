using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu.Models
{
    public class HastaModel
    {
        public int Hastaıd;
        public string Hastaİsim;
        public string HastaSoyİsim;
        public int HastaYas;
        public string HastaTCNo;
        public string HastaTelefon;
        public string HastaHesKodu;
        public string HastaMail;
        public string HastaSifre;
        public string HastaCinsiyet;

        public HastaModel() { 
        }
        public HastaModel( string Hastaİsim, string HastaSoyİsim, int HastaYas, string HastaTCNo, string HastaTelefon, string HastaHesKodu, string HastaMail, string HastaSifre, string HastaCinsiyet)
        {
            this.Hastaİsim = Hastaİsim;
            this.HastaSoyİsim = HastaSoyİsim;
            this.HastaYas = HastaYas;
            this.HastaTCNo = HastaTCNo;
            this.HastaTelefon = HastaTelefon;
            this.HastaHesKodu = HastaHesKodu;
            this.HastaMail = HastaMail;
            this.HastaSifre = HastaSifre;
            this.HastaCinsiyet = HastaCinsiyet;
            
        }

    }
}
