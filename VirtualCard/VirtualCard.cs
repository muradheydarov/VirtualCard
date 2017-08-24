using System;

namespace VirtualCard
{
    class VirtualCard
    {
        string userName;
        string expireDateVirtual;
        int money;
        string currency = "USD";
        long number = MakeRandom.ShowCardNumber();
        long cvc = MakeRandom.ShowCvc();

        public VirtualCard(string owner,int expireDate,int money)
        {
            this.money = money;
            userName = owner;
            this.expireDateVirtual = DateTime.Now.AddYears(expireDate).ToString("MM/yyyy");
        }

        public void ShowVirtual()
        {
            Console.WriteLine("Virtual kartiniz hazirdir...\nUser name: {0}\nCard number {1}\nExpire date: {2}\nCVC: {3}\nMoney: {5}\nCurrency: {4}",userName,number,expireDateVirtual,cvc,currency,money);
        }
    }
}
