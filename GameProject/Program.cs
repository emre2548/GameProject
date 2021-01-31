using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.     Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. 
            Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. 
            (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

            2.     Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir.
            Oyuncunun parametre olarak metotta olmasını kastediyorum.)

            3.     Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

            4.     Satışlarda kampanya entegrasyonunu simule ediniz.
             */

            BaseCustomerManager customerManager = new BaseCustomerManager();
            BaseCampaingService campaingService = new BaseCampaingService();
            BaseGameManager gameService = new BaseGameManager();

            Game game = new Game();
            Customer customer = new Customer();
            Campaing campaing = new Campaing();

            game.Id = 1;
            game.GameName = "Game1";
            game.Price = 54.6f;

            customer.FirstName = "Kullanıcı1";
            customer.LastName = "LastName";
            customer.TcNo = "0123456789";
            customer.Id = 1;
            customer.CustomerBuyGame = "Game 1";

            campaing.Id = 1;
            campaing.CampaingName = "İndirim Sezonu";
            campaing.Discount = 10;
            campaing.GameId = 1;

            customerManager.Add(customer);

            gameService.Add(game);

            campaingService.Add(campaing,game);

            campaingService.BuyWithDiscound(game,customer,campaing);



            campaingService.Add();

            Console.ReadLine();

        }
    }
}
