using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password; 
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine(password + " şifresi doğru.");
            //}
            //else
            //{
            //    Console.WriteLine(password + " şifresi yanlış.");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğru.");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi. ");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı 5'e eşit.");
            //}
            //else if (number > 5)
            //{
            //    Console.WriteLine("Sayı 5'ten büyük.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 5'ten küçük.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average>0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "İstanbul" | city == "Ankara" | city == "Ankara")
            //{
            //    Console.WriteLine(city + " Şehiri hakkında veri tabanında bilgiler bulunmaktadır");
            //}
            //else
            //{
            //    Console.WriteLine(city + " Şehiri hakkında veri tabanında bilgiler bulunmamaktadır.");
            //}

            //Console.Write("Lütfen kullanıcı adı giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez ");
            //}
            //else
            //{
            //    Console.Write("Sisteme Hoşgeldiniz: " + username);
            //}
            #endregion

            #region Mod İşlemleri

            //Console.Write("5'e bölümünden kalanını merak etmiş olduğunuz sayıyı giriniz: ");
            //int number;
            //number = int.Parse(Console.ReadLine());
            //int result = number % 5;
            //Console.WriteLine(number + " sayısının 5'e bölümünden kalan: " + result);

            //Console.Write("Sizlerden iki sayı girmenizi istiyorum girmiş olduğunuz 1.sayının 2. sayıya bölümünden kalanı sizlere söyleyeceğim. ");

            //int number1, number2, result;

            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz: ");   
            //number2 = int.Parse(Console.ReadLine());

            //result = number1 % number2;

            //Console.WriteLine(number1 + " sayısının " + number2 + " sayısına bölümünden kalan: " + result);

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Girmiş olduğunuz " + number + "sayısı çifttir.");
            //}
            //else
            //{
            //    Console.Write("Girmiş olduğunuz " + number + " sayısı tektir.");
            //}
            #endregion

            #region Char Değişkenleri ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.Write("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();
            //Console.WriteLine();

            //if ( menuItem == "1")
            //{
            //    Console.WriteLine("----------Ana Yemekler---------");
            //    Console.WriteLine("1- Tavuk");
            //    Console.WriteLine("2- Köfte");
            //    Console.WriteLine("3- Balık");
            //    Console.WriteLine("----------Ana Yemekler---------");
            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Tarhana Çorbası");
            //    Console.WriteLine("3- Yayla Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");
            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine("---------Pizzalar----------");
            //    Console.WriteLine("1- Margherita Pizza");
            //    Console.WriteLine("2- Pepperoni Pizza");
            //    Console.WriteLine("3- Sebzeli Pizza");
            //    Console.WriteLine("---------Pizzalar----------");
            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine("---------İçecekler---------");
            //    Console.WriteLine("1- Su");
            //    Console.WriteLine("2- Kola");
            //    Console.WriteLine("3- Çay");
            //    Console.WriteLine("---------İçecekler---------");
            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine("---------Tatlılar----------");
            //    Console.WriteLine("1- Baklava");
            //    Console.WriteLine("2- Sütlaç");
            //    Console.WriteLine("3- Kadayıf");
            //    Console.WriteLine("---------Tatlılar----------");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz menü seçimi.");
            //}

            #endregion

            #region Switch Case













            #endregion

            Console.Read();
        }
    }
}
