using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IWalletService
    {
        void Show(Wallet walletManager);
        void Update(Wallet walletManager);
    }
}
