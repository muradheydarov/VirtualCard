using System;

namespace VirtualCard
{
    class RealCard
    {           
        string userName = "muradheydarov";
        string password = "12345";

        string cardNumber = "8795257401256302";
        string expireDate = DateTime.Now.AddYears(5).ToString("MM/yyyy");
        string NameSurname = "Murad Heydarov";        
        string cvc = "586";
        int money = 5000;
        string currency = "USD";

        public RealCard(string userName, string password)
        {
            
            if (userName==this.userName&&password==this.password)
            {
                Console.WriteLine("User details: ");
                Console.WriteLine();
                Console.WriteLine("User name and surname: {0}\nCard Number: {1}\nExpire Date: {2}\nCVC: {4}\nMoney: {5}\nCurrency: {3}", NameSurname,cardNumber,expireDate,currency,cvc,money);
                Console.WriteLine();
                Console.Write("Yeni virtual kart yaratmaq isteyirsinizmi? (y/n)");
                string decision = Console.ReadLine();
                Console.WriteLine();
                
                if (decision=="y")
                {
                    Console.WriteLine("Virtual kartin sahibinin adi ve soyadi: ");                    
                    string owner = Console.ReadLine();
                    Label:
                    Console.WriteLine("Yatiracaginiz mebleg: ");
                    int money = Convert.ToInt32(Console.ReadLine());
                    if (money>this.money)
                    {
                        Console.WriteLine("Hesabda olan puldan artiq pul yatirila bilmez!!! Zehmet olmasa duzelis edin...");
                        goto Label;
                    }
                    else
                    {
                        Label2:
                        Console.WriteLine("Etibarliliq muddeti (Qeyd: Maksimum 5 il): ");
                        int expireDate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (expireDate > 5)
                        {
                            Console.WriteLine("Istifade muddeti maksimum 5 il ola biler!!! Zehmet olmasa duzelis edin");
                            Console.WriteLine();
                            goto Label2;
                        }
                        else
                        {
                            VirtualCard tor = new VirtualCard(owner, expireDate, money);
                            tor.ShowVirtual();
                        }
                    }                                         
                }
                else
                {
                    Console.WriteLine("Emeliyyat dayandirildi!!!");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Sifre ve ya istifadeci adi yalnisdir");
            }
        }
    }
}
