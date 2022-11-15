using Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RealEstateAgency.Tests
{
    public class HouseTests
    {
        [Fact]
        public void StartsWithHouseNum()
        {
            //Arrange
            var house = new House() { Number = "Будинок №2", Region = "Київська ", Address = new Address { Street = "Бальзака" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            //Act
            string actual = house.Print();
            //Assert
            Assert.StartsWith("Область:Київська ", actual);
        }

        [Fact]
        public void FullAddressName()
        {
            //Arrange
            string expected = "Вінницька Соборна";
            var house = new House() { Number = "Будинок №1", Region = "Вінницька ", Address = new Address { Street = "Соборна" }, Price = 1000, Area = 100, NumberOfFloors = 1 };
            //Act
            string actual = house.Return_Address();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalAreaPrice_3floors_40sqMeters()
        {
            //Arrange
            decimal expected = 3694830;
            var house = new House() { Number = "Будинок №2", Region = "Київська ", Address = new Address { Street = "Бальзака" }, Price = 1000, Area = 40, NumberOfFloors = 3 };
            //Act
            decimal actual = house.Purchase_Price(house.Area, house.NumberOfFloors, 0);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalAreaPrice_1floor_30sqMeters()//separated from previous unit test
        {
            //Arrange
            decimal expected = 902723.1M;
            var house = new House() { Number = "Будинок №84A", Region = "Київська ", Address = new Address { Street = "Сержа Лифаря" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            int precision = 2;
            //Act
            decimal actual = house.Purchase_Price(house.Area, house.NumberOfFloors, 30090.77M);
            //Assert
            Assert.Equal(expected, actual, precision);
        }

        [Fact]
        public void RieltorPart_Is_3to5_Percent()
        {
            //Arrange
            var purchased_house = new House() { Number = "Будинок №2", Region = "Київська ", Address = new Address { Street = "Бальзака" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            decimal price = 902723.1M;
            //Act
            decimal actual = purchased_house.RieltorPart(price, 0.05M);
            //Assert
            Assert.InRange<decimal>(actual, 18054.462M, 54163.386M);
        }

        [Fact]
        public void RealPrice_WhenHave_PricePerMeter_AndRieltorPercent()
        {
            //Arrange
            decimal RieltorPart = 0.05M;
            var purchased_house = new House() { Number = "Будинок №2", Region = "Київська ", Address = new Address { Street = "Бальзака" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            decimal price = 902723.1M;
            decimal expected = 947859.255M;
            //Act
            decimal actual = purchased_house.RealPrice(price, RieltorPart);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Purchasing_Condition_true()
        {
            //Arrange
            var purchasing_house = new House() { Number = "Будинок №2", Region = "Київська ", Address = new Address { Street = "Бальзака" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            decimal price = 902723.1M;
            purchasing_house.DocumentsAreVerified = true;
            decimal RealPrice = 902723.1M + 902723.1M * 0.05M;
            //Act
            bool actual = purchasing_house.Purchasing(purchasing_house.DocumentsAreVerified, price, RealPrice);
            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void Purchasing_Condition_false_lessPrice()
        {
            //Arrange
            var purchasing_house = new House() { Number = "Будинок №2", Region = "Київська ", Address = new Address { Street = "Бальзака" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            decimal price = 93.1M;
            purchasing_house.DocumentsAreVerified = true;
            decimal RealPrice = 902723.1M + 902723.1M * 0.05M;
            //Act
            bool actual = purchasing_house.Purchasing(purchasing_house.DocumentsAreVerified, price, RealPrice);
            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Purchasing_Condition_false_no_docs()
        {
            //Arrange
            var purchasing_house = new House() { Number = "Будинок №2", Region = "Київська ", Address = new Address { Street = "Бальзака" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            decimal price = 902723.1M;
            purchasing_house.DocumentsAreVerified = false;
            decimal RealPrice = 902723.1M + 902723.1M * 0.05M;
            //Act
            bool actual = purchasing_house.Purchasing(purchasing_house.DocumentsAreVerified, price, RealPrice);
            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void FilterTest_for_Another_Type()
        {
            //Arrange
            int temp = 0;
            var house2 = new House() { Number = "Будинок №2", Region = "Чернігівська ", Address = new Address { Street = "Шевченка" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            bool expected = false;
            //Act
            bool actual = house2.Filter(temp, house2);
            //Asseet
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterTest_for_null()
        {
            //Arrange
            var house2 = new House() { Number = "Будинок №2", Region = "Чернігівська ", Address = new Address { Street = "Шевченка" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            bool expected = false;
            //Act
            bool actual = house2.Filter(null, house2);
            //Asseet
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, null, 0, 0, 0, 0, 1, true)]
        [InlineData(null, null, null, 0, 0, 10, 20, 1, true)]
        [InlineData(null, null, null, 0, 10, 20, 0, 1, true)]
        [InlineData(null, null, null, 0, 10, 20, 30, 1, true)]
        [InlineData(null, null, null, 0, 30, 20, 10, 1, false)]
        public void FilterTest_for_Area(string Number, string Region, string Address, int Price, double Area1, double Area2, double Area3, int Floors, bool Passing)//
        {
            //Arrange
            var house1 = new House() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price, Area = Area1, NumberOfFloors = Floors };
            var house2 = new House() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price, Area = Area2, NumberOfFloors = Floors };
            var house3 = new House() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price, Area = Area3, NumberOfFloors = Floors };
            bool expected = Passing;
            //Act
            bool actual = house2.Filter(house1, house3);
            //Asseet
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, null, 0, 0, 0, 0, 1, true)]
        [InlineData(null, null, null, 0, 10, 20, 0, 1, true)]
        [InlineData(null, null, null, 10, 20, 0, 0, 1, true)]
        [InlineData(null, null, null, 10, 20, 30, 0, 1, true)]
        [InlineData(null, null, null, 30, 20, 10, 0, 1, false)]
        public void FilterTest_for_Price(string Number, string Region, string Address, int Price1, int Price2, int Price3, double Area, int Floors, bool Passing)//
        {
            //Arrange
            var house1 = new House() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price1, Area = Area, NumberOfFloors = Floors };
            var house2 = new House() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price2, Area = Area, NumberOfFloors = Floors };
            var house3 = new House() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price3, Area = Area, NumberOfFloors = Floors };
            bool expected = Passing;
            //Act
            bool actual = house2.Filter(house1, house3);
            //Asseet
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, null, 0, 0, 0, 0, 0, true)]
        [InlineData(null, null, null, 0, 0, 0, 10, 20, true)]
        [InlineData(null, null, null, 0, 0, 10, 20, 0, true)]
        [InlineData(null, null, null, 0, 0, 10, 20, 30, true)]
        [InlineData(null, null, null, 0, 0, 30, 20, 10, false)]
        public void FilterTest_for_Number_of_Floors(string Number, string Region, string Address, int Price, double Area, int Floors1, int Floors2, int Floors3, bool Passing)//
        {
            //Arrange
            var house1 = new House() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price, Area = Area, NumberOfFloors = Floors1 };
            var house2 = new House() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price, Area = Area, NumberOfFloors = Floors2 };
            var house3 = new House() { Number = Number, Region = Region, Address = new Address { Street = Address }, Price = Price, Area = Area, NumberOfFloors = Floors3 };
            bool expected = Passing;
            //Act
            bool actual = house2.Filter(house1, house3);
            //Asseet
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, "", null, null, null, 0, 0, 0, true)]
        [InlineData(null, "Всі", null, null, null, 0, 0, 0, true)]
        [InlineData(null, "Київська", "Київська", null, null, 0, 0, 0, true)]
        [InlineData(null, "Київська", "Львівська", null, null, 0, 0, 0, false)]
        public void FilterTest_for_Region(string Number, string Region1, string Region2, string Region3, string Address, int Price, double Area, int Floors, bool Passing)//
        {
            //Arrange
            var house1 = new House() { Number = Number, Region = Region1, Address = new Address { Street = Address }, Price = Price, Area = Area, NumberOfFloors = Floors };
            var house2 = new House() { Number = Number, Region = Region2, Address = new Address { Street = Address }, Price = Price, Area = Area, NumberOfFloors = Floors };
            var house3 = new House() { Number = Number, Region = Region3, Address = new Address { Street = Address }, Price = Price, Area = Area, NumberOfFloors = Floors };
            bool expected = Passing;
            //Act
            bool actual = house2.Filter(house1, house3);
            //Asseet
            Assert.Equal(expected, actual);
        }
    }
}
