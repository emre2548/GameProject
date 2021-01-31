using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public class BaseCampaingService : IDataManager,ICampaingService
    {
        public void Add()
        {
            //Console.WriteLine("Yeni Kampanya Eklendi");
        }

        public void Delete()
        {
            //Console.WriteLine("Yeni Kampanya Eklendi");
        }

        public void Update()
        {
            //Console.WriteLine("Yeni Kampanya Eklendi");
        }

        public void Add(Campaing campaing,Game game)
        {
            Console.WriteLine(campaing.CampaingName + " Kampanyası" + game.GameName +" Eklendi");
        }

        public void Delete(Campaing campaing, Game game)
        {
            Console.WriteLine(campaing.CampaingName + " Kampanyası " + game.GameName + " Silindi.");
        }

        public void Update(Campaing campaing, Game game)
        {
            Console.WriteLine(campaing.CampaingName + " Kampanyası " + game.GameName + " Güncellendi.");
        }

        public void BuyWithDiscound(Game game, Customer customer, Campaing campaing)
        {
            Console.WriteLine(customer.FirstName + " Kullanıcısı " + game.GameName + " Oyununu " + campaing.CampaingName + " Kampanyasından " + campaing.Discount + " indirimle aldı.");
        }
    }
}
