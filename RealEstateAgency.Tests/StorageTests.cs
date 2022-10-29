using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Design;

namespace RealEstateAgency.Tests
{
   public class StorageTests
    {
        public void PricePerYear()
        {
            int pricePerMonth = 50;
            int countOfMonth = 12;
            int expected = pricePerMonth * countOfMonth;
            Storage storage = new Storage() { Number = "Квартира №5", Region = "Дніпропетровська", Address = new Address { Street = "Східна" }, Price = 50, Area = 100 };
            int actual = storage.PricePerYear();

            Assert.Equal(expected, actual);
        }
    }
}
