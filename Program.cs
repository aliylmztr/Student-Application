using System;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;

            Ogrenci ogrenci1 = new Ogrenci(1, "Enes", "Bayram", 50, 40, 73, "Doğuş Üniversitesi");

            islemleriGoster();

            while (kontrol)
            {
                Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;
                    case "2":
                        ogrenci1.ogrenciOrtalamasiBul();
                        break;
                    case "3":
                        ogrenci1.okulGetir();
                        break;
                    case "4":
                        kontrol = false;
                        break;
                }
            }
        
        }

        static void islemleriGoster()
        {
            Console.WriteLine("İŞLEMLER:");
            Console.WriteLine("1- Öğrenci Bilgilerini Göster");
            Console.WriteLine("2- Öğrenci Ortalamasını Göster");
            Console.WriteLine("3- Öğrencinin Okulunu Göster");
            Console.WriteLine("4- Çıkış Yap");
        }

    }
}
