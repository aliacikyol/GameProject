using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaignManager)
        {
            Console.WriteLine(campaignManager.CampaignName+":"+campaignManager.CampaignPrice+"$");
        }

        public void Delete(Campaign campaignManager)
        {
            
        }

        public void Update(Campaign campaignManager)
        {
            
        }
    }
}
