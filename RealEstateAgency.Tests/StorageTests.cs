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
        public void StoragePrint()
        {
            string expected = "Номер будинку : 1 , Область : Дніпропетровська , Вулиця : Соборна , Ціна : 100 , Площа : 100";

            Storage storage = new Storage() { Number = "1", Region = "Дніпропетровська", Address = new Address { Street = "Соборна" }, Price = 100, Area = 100 };
            string actual = storage.Print();

            
            Assert.Equal(expected, actual);
        }

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

        [Fact]
        public void FilterAtNull_BoolCheckReturnFalse()
        {
            Storage storageform = new Storage() { Number = "1", Region = "", Address = new Address { Street = "Східна" }, Price = 80, Area = 0 };
            Storage storagethis = new Storage() { Number = "3", Region = "", Address = new Address { Street = "Східна" }, Price = 100, Area = 0 };
            bool actual = storagethis.Filter(null, storageform);

            bool expected = false;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterPriceAt80To120_BoolCheckReturnTrue()
        {
            Storage storageform = new Storage() { Number = "1", Region = "", Address = new Address { Street = "Соборна" }, Price = 70, Area = 0 };
            Storage storageto = new Storage() { Number = "2", Region = "", Address = new Address { Street = "Соборна" }, Price = 120, Area = 0 };
            Storage storagethis = new Storage() { Number = "3", Region = "", Address = new Address { Street = "Соборна" }, Price = 100, Area = 0 };
            bool actual = storagethis.Filter(storageform, storageto);

            bool expected = true;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterAreaAt90To130_BoolCheckReturnTrue()
        {

            Storage storageform = new Storage() { Number = "1", Region = "", Address = new Address { Street = "Соборна" }, Price = 0, Area = 90 };
            Storage storageto = new Storage() { Number = "2", Region = "", Address = new Address { Street = "Соборна" }, Price = 0, Area = 130 };
            Storage storagethis = new Storage() { Number = "3", Region = "", Address = new Address { Street = "Соборна" }, Price = 0, Area = 100 };
            bool actual = storagethis.Filter(storageform, storageto);

            bool expected = true;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterCastingTypes_BoolCheckReturnTrue()
        {
            Storage storageform = new Storage() { Number = "1", Region = "", Address = new Address { Street = "Соборна" }, Price = 70, Area = 0 };
            Storage storagethis = new Storage() { Number = "2", Region = "", Address = new Address { Street = "Соборна" }, Price = 90, Area = 0 };
            bool actual = storagethis.Filter(new DateTime(), storageform);

            bool expected = false;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterRegion_BoolCheckReturnTrue()
        {
            Storage storageform = new Storage() { Number = "1", Region = "Дніпро", Address = new Address { Street = "Соборна" }, Price = 0, Area = 0 };
            Storage storageto = new Storage() { Number = "2", Region = "Дніпро", Address = new Address { Street = "Соборна" }, Price = 0, Area = 0 };
            Storage storagethis = new Storage() { Number = "3", Region = "Дніпро", Address = new Address { Street = "Соборна" }, Price = 0, Area = 0 };
            bool actual = storagethis.Filter(storageform, storageto);

            bool expected = true;

            Assert.Equal(expected, actual);
        }
    }
}
