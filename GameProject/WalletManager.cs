using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class WalletManager : IWalletService
    {
        public void Show(Wallet walletManager)
        {
            Console.WriteLine("Cüzdan Bakiyesi:"+walletManager.WalletBalance+"$");
        }

        public void Update(Wallet walletManager)
        {
            
        }
    }
}
