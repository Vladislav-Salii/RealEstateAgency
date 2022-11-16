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

        [Theory]
        [InlineData(null, null, null, 0, 0, 0, 0, true)]
        [InlineData(null, null, null, 0, 10, 20, 0, true)]
        [InlineData(null, null, null, 10, 20, 0, 0, true)]
        [InlineData(null, null, null, 10, 20, 30, 0, true)]
        [InlineData(null, null, null, 30, 20, 10, 0, false)]
        public void FilterTest_for_Price(string Number, string Region, string Address, int Price1, int Price2, int Price3, double Area, bool Passing)
        {
            //Arrange
            var storage1 = new Storage() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price1, Area = Area };
            var storage2 = new Storage() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price2, Area = Area };
            var storage3 = new Storage() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price3, Area = Area };
            bool expected = Passing;
            //Act
            bool actual = storage2.Filter(storage1, storage3);
            //Asseet
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

        [Theory]
        [InlineData(null, null, null, 0, 0, 0, 0,  true)]
        [InlineData(null, null, null, 0, 0, 10, 20, true)]
        [InlineData(null, null, null, 0, 10, 20, 0, true)]
        [InlineData(null, null, null, 0, 10, 20, 30, true)]
        [InlineData(null, null, null, 0, 30, 20, 10, false)]
        public void FilterTest_for_Area(string Number, string Region, string Address, int Price, double Area1, double Area2, double Area3, bool Passing)
        {
            
            var storage1 = new Storage() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price, Area = Area1 };
            var storage2 = new Storage() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price, Area = Area2 };
            var storage3 = new Storage() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price, Area = Area3 };
            bool expected = Passing;
           
            bool actual = storage2.Filter(storage1, storage3);
            
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


        [Theory]
        [InlineData(null, "", null, null, null, 0, 0, true)]
        [InlineData(null, "Всі", null, null, null, 0, 0, true)]
        [InlineData(null, "Київська", "Київська", null, null, 0, 0, true)]
        [InlineData(null, "Київська", "Львівська", null, null, 0, 0, false)]

        public void FilterTest_for_Region(string Number, string Region1, string Region2, string Region3, string Address, int Price, double Area, bool Passing)
        {
            
            var storage1 = new Storage() { Number = Number, Region = Region1, Address = new Address { Street = Address }, Price = Price, Area = Area };
            var storage2 = new Storage() { Number = Number, Region = Region2, Address = new Address { Street = Address }, Price = Price, Area = Area };
            var storage3 = new Storage() { Number = Number, Region = Region3, Address = new Address { Street = Address }, Price = Price, Area = Area };
            bool expected = Passing;
            
            bool actual = storage2.Filter(storage1, storage3);
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterTest_for_Another_Type()
        {
            
            int temp = 0;
            var storage = new Storage() { Number = "2", Region = "Львівська ", Address = new Address { Street = "Соборна" }, Price = 100, Area = 50 };
            bool expected = false;
           
            bool actual = storage.Filter(temp, storage);
            
            Assert.Equal(expected, actual);
        }

    }
}
