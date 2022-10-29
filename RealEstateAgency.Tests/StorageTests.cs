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
        [Fact]
        public void PricePerYear()
        {
            int pricePerMonth = 50;
            int countOfMonth = 12;
            int expected = pricePerMonth * countOfMonth;

            Storage storage = new Storage() { Number = "5", Region = "Дніпропетровська", Address = new Address { Street = "Східна" }, Price = 50, Area = 100 };
            int actual = storage.PricePerYear();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SummArea()
        {
            int AmountRooms = 3;
            double Area = 200;
            double expected = Area * AmountRooms;

            Storage storage = new Storage() { Number = "3", Region = "Дніпропетровська", Address = new Address { Street = "Соборна" }, Price = 50, Area = 200 };
            double actual = storage.SummArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OurRegion()
        {
            string Region1 = "Дніпро";
            string Region2 = "Київ";
            string expected = Region1 + Region2;

            Storage storage = new Storage() { Number = "8", Region = "ДніпроКиїв", Address = new Address { Street = "Соборна" }, Price = 50, Area = 200 };
            string actual = storage.OurRegion();

            Assert.Equal(expected, actual);
        }
    }
}
