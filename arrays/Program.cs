using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] city = { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Sivas", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };

            //for (int i = 0; i <= city.Length; i++)
            //{
            //    Console.WriteLine(i + 1 + ": " +city[i]);
            //}

            //int i = 1;
            //foreach(string x in city)
            //{
            //    Console.WriteLine(i + ": " + x);
            //    i++;
            //}

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 2345, 435546, 5436, 23435, 45645123, 1234345, 345, 345234231, 354 };

            //foreach (int i in nums)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            int num = int.Parse(Console.ReadLine());

            int tausends = num / 1000;
            int hunderts = (num % 1000) / 100;
            int tents = (num % 100) / 10;
            int ones = num % 10;

            int result = tausends + hunderts + tents + ones;
            Console.WriteLine(result);
        }
    }
}
