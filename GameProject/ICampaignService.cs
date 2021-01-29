using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign campaignManager);
        void Update(Campaign campaignManager);
        void Delete(Campaign campaignManager);

    }
}
