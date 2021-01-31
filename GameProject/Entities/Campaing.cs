using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;


namespace GameProject.Entities
{
    public class Campaing:IEntity
    {
        public int Id { get; set; }
        public string CampaingName { get; set; }
        public float Discount { get; set; }
        public int GameId { get; set; }
    }
}
