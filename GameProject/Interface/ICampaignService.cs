using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interface
{
    class ICampaignService
    {
        void CalculateSale(Game game);
        void SaleInformation(Game game);

        public static implicit operator ICampaignService(StudentCampaign v)
        {
            throw new NotImplementedException();
        }
    }
}
