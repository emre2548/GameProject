using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    class BaseGameManager : IDataManager
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu Güncellendi");
        }
    }
}
