using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yemeksepeti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double secim, adet, toplam = 0;
            double hesap = 0;
            double ödememiktar,ödemesonuc;
            Console.WriteLine("****************************************************************");
            Console.WriteLine("**                            **                              **");
            Console.WriteLine("**       Yemekler             **       İçecekler              **");
            Console.WriteLine("**                            **                              **");
            Console.WriteLine("**  1-Et Döner = 7.00 TL      **    7-Ayran = 1.00 TL         **");
            Console.WriteLine("**                            **                              **");
            Console.WriteLine("**  2-Tavuk Döner = 5.00 TL   **    8-Kola = 3.00TL           **");
            Console.WriteLine("**                            **                              **");
            Console.WriteLine("**  3-Çorba = 4.00 TL         **    9-Su = 0.50 Krş           **");
            Console.WriteLine("**                            **                              **");
            Console.WriteLine("**  4-Salata = 2.50 TL        **    10-Çay = 0.75 Krş         **");
            Console.WriteLine("**                            **                              **");
            Console.WriteLine("**  5-Kuru - Pilav = 6.00 TL  **    11-Fanta = 2.00 TL        **");
            Console.WriteLine("**                            **                              **");
            Console.WriteLine("**  6-Pide = 6.50TL           **    12-Soda = 1.00 TL         **");
            Console.WriteLine("**                            **                              **");
            Console.WriteLine("****************************************************************");
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("");
                Console.Write("Alacağınız Ürünün Numarasını Giriniz: ");
                secim = Convert.ToDouble(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Kaç Porsiyon Et Döner İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7;
                    hesap = hesap + toplam;
                }
                else if (secim == 2)
                {
                    Console.Write("Kaç Porsiyon Tavuk Döner İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap = hesap + toplam;
                }
                else if (secim == 3)
                {
                    Console.Write("Kaç Porsiyon Çorba İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 4;
                    hesap = hesap + toplam;
                }
                else if (secim == 5)
                {
                    Console.Write("Kaç Porsiyon Kuru-Pilav İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6;
                    hesap = hesap + toplam;
                }
                else if (secim == 6)
                {
                    Console.Write("Kaç Porsiyon Pide İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6.50;
                    hesap = hesap + toplam;
                }
                else if (secim == 7)
                {
                    Console.Write("Kaç Adet Ayran İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap = hesap + toplam;
                }
                else if (secim == 8)
                {
                    Console.Write("Kaç Adet Kola İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 3;
                    hesap = hesap + toplam;
                }
                else if (secim == 9)
                {
                    Console.Write("Kaç Adet Su İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 0.50;
                    hesap = hesap + toplam;
                }
                else if (secim == 10)
                {
                    Console.Write("Kaç Adet Çay İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 0.75;
                    hesap = hesap + toplam;
                }
                else if (secim == 11)
                {
                    Console.Write("Kaç Adet Fanta İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2;
                    hesap = hesap + toplam;
                }
                else if (secim == 12)
                {
                    Console.Write("Kaç Adet Soda İstersiniz: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap = hesap + toplam;
                }
                else             
                    Console.WriteLine("Böyle Bir Seçim Yok:");
                    Console.Write("Başka İsteğiniz Var mı ? :");
                    string cevap = Console.ReadLine();
                    if (cevap == "h" || cevap == "H" || cevap == "Hayır" || cevap == "hayır" || cevap == "HAYIR" ) 
                    break;                       
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Toplam Alınacak Hesap Tutarı: " + hesap+" TL");
            Console.WriteLine("****************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;            
            Console.WriteLine();
            Console.Write("Müşteriden Alınan Para: ");
            ödememiktar = Convert.ToDouble(Console.ReadLine());
            ödemesonuc = ödememiktar-hesap;
            Console.WriteLine();
            Console.WriteLine("****************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Müşteriye Verilecek Para: " + ödemesonuc+" TL") ;
            Console.WriteLine("****************************************");
            Console.ReadLine();
        }
    }
}
