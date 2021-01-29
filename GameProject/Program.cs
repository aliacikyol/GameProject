using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager    = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Engin",
                LastName = "Demirog",
                IdentityNumber = 12345
            });
            Console.WriteLine("******************");
            WalletManager walletManager = new WalletManager();
            walletManager.Show(new Wallet {WalletBalance=100 });
            Console.WriteLine("******************");
            Console.WriteLine("Oyun Mağazası");
            ProductManager productManager = new ProductManager();
            productManager.List(new Product {ProductName="Mavi Elmas",ProductPrice=30 });
            productManager.List(new Product { ProductName = "Kırmızı Elmas", ProductPrice = 40 });
            productManager.List(new Product { ProductName = "Yeşil Elmas", ProductPrice = 50 });
            Console.WriteLine("******************");
            Console.WriteLine("Kampanyalar");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign {CampaignName="Mavi+Kırmızı Kampanyası",CampaignPrice=60 });
            campaignManager.Add(new Campaign { CampaignName = "Mavi+Yeşil Kampanyası", CampaignPrice = 70 });
            campaignManager.Add(new Campaign { CampaignName = "Kırmızı+Yeşil Kampanyası", CampaignPrice = 80 });




        }
    }
}

