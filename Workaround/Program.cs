using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() 
            {
                FirstName = "ferit",
                LastName = "star",
                DateOfBirthYear = 1990,
                NationalIdentity = 987
            };

            Person person2 = new Person()
            {
                FirstName = "Abc",
                LastName = "Qwe",
                DateOfBirthYear = 1990,
                NationalIdentity = 123
            };

            //SelamVer(person.FirstName + " " + person.LastName);
            //SelamVer();

            //int sonuc = Topla(3, 5);
            //int sonuc2 = Topla();

            PttManager pttManager1 = new PttManager(new PersonManager());
            pttManager1.GiveMask(person);
            pttManager1.GiveMask(person2);
            PttManager pttManager2 = new PttManager(new ForeignerManager());

            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            var sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + sonuc.ToString());
            return sonuc;
        }
    }
}
