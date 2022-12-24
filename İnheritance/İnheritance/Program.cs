using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //                      KALITIM 
            // KALITIM OOP NİN EN ÖNEMLİ ÖZELLİĞİDİR
            // ÜRETİLEN NESNELER FARKLI NESNELERE ÖZELLİKLERİNİ AKTARABİLMEKTE VE
            // BÖYLECE HİYERARŞİK BİR DÜZENLEME YAPILABİLMEKTEDİR
            // AYNI AİLE GRUBNDAN GELEN NESNELERİN VE YATAYDA EŞİT SEVİYEDE OLAN
            // TÜM OLGULARIN BENZER ÖZELLİKLERİNİ TEKRAR TEKRAR HERBİRİNE TANIMLAMAKTANSA
            // ORTAK OLAN ÖZELLİKLERİ ÜST SINIFA AL VE KALITIMSAL OLARAK ALMASINI SAĞLA  

            Muhasebeci muhasebeci = new Muhasebeci();
            Mudur mudur = new Mudur();
            Yazılımcı yazılımcı = new Yazılımcı();
            yazılımcı.         



        }
    }
    class Personel
    {
        public string Adı { get; set; }
        public string Soyadi { get; set; }

        public bool MedeniHal { get; set; }
    }

    class Muhasebeci : Personel
    {
        public bool Müsavir { get; set; }
    }
    class Yazılımcı : Personel
    {
        public string[] KullandıgıDiller { get; set; }
    }
    class Mudur : Personel
    {

    }

}
