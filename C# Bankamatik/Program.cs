using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    internal class Program
    {
        static void Main()
        {
            int bakiye = 200;

            while (true) {
                {
                    Console.WriteLine("Atm Menüsü");
                    Console.WriteLine("1. Bakiye Sorgula");
                    Console.WriteLine("2. Para Yatır");
                    Console.WriteLine("3. Para Çek");
                    Console.WriteLine("4. Fatura öde");
                    Console.WriteLine("5. Hesap sil");
                    Console.Write("Seçim yap: ");

                    char secim = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    switch (secim)
                    {
                        case '1': Console.WriteLine("Hesabındaki para " + bakiye); break;
                        case '2': Console.WriteLine("Para yatırıldı !!!(Şu anda çalışmıyor...)"); break;
                        case '3': Console.WriteLine("Para çekildi !!!(Şu anda çalışmıyor...)"); break;
                        case '5': Console.WriteLine("Hesabı silmek istediğine emin misin (e/h)");
                            string onay = Console.ReadLine();
                            if (onay == "e")
                            {
                                bakiye = 0;
                                Console.WriteLine("Hesabın silindi ve paran sıfırlandı");
                            }
                            else if (onay == "h")
                            {
                                Console.WriteLine("İşlem iptal edildi");
                            }
                            break;
                        case '4': Console.WriteLine("Ödenecek fatura tutarı: 250TL \n Ödemek istiyor musunuz?");
                            string fatura = Console.ReadLine();
                            if (fatura == "e")
                            {
                                if (bakiye >= 250)
                                {
                                    bakiye -= 250;
                                    Console.WriteLine("Faturan ödendi."); break;
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz bakiye."); break;
                                }
                            }
                            else if (fatura == "h")
                            {
                                Console.WriteLine("İşlemi iptal et");
                                Console.Write("İşlem iptal edildi");
                            }
                            break;

                    }
                    Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
    }
}