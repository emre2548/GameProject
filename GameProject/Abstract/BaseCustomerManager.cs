using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    class BaseCustomerManager : IDataManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Kullanıcı Eklendi : " + customer.FirstName);
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Kullanıcı Silindi : " + customer.FirstName);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Kullanıcı Güncellendi : " + customer.FirstName);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
