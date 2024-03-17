using System;

namespace StudentApplication
{
    public class Ogrenci
    {
        private int no;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int no, string isim, string soyisim, int vize1, int vize2, int final, string okulIsmi)
        {
            this.no = no;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.final = final;
            this.okulIsmi = okulIsmi;
        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrenci Numarası: " + no);
            Console.WriteLine("Öğrenci İsmi: " + isim);
            Console.WriteLine("Öğrenci Soyismi: " + soyisim);
            Console.WriteLine("Öğrenci Vize1: " + vize1);
            Console.WriteLine("Öğrenci Vize2: " + vize2);
            Console.WriteLine("Öğrenci Final: " + final);
            
        }

        public double ogrenciOrtalamasiBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            Console.WriteLine("Öğrenci Ortalaması: " + ortalama);
            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Öğrencinin Okul İsmi: " + okulIsmi);
        }

    }
}
