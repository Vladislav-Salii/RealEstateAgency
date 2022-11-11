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

        [Fact]
        public void FilterTest_for_Area()
        {
            //Arrange
            var house1 = new House() { Number = "", Region = "", Address = new Address { Street = "" }, Price = 1000, Area = 30, NumberOfFloors = 1 };
            var house2 = new House() { Number = "", Region = "", Address = new Address { Street = "" }, Price = 1000, Area = 20, NumberOfFloors = 1 };
            var house3 = new House() { Number = "", Region = "", Address = new Address { Street = "" }, Price = 1000, Area = 10, NumberOfFloors = 1 };
            bool expected = false;
            //Act
            bool actual = house2.Filter(house1, house3);
            //Asseet
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterTest_for_Price()
        {
            //Arrange
            var house1 = new House() { Number = "", Region = "", Address = new Address { Street = "" }, Price = 1001, Area = 20, NumberOfFloors = 1 };
            var house2 = new House() { Number = "", Region = "", Address = new Address { Street = "" }, Price = 1000, Area = 20, NumberOfFloors = 1 };
            var house3 = new House() { Number = "", Region = "", Address = new Address { Street = "" }, Price =  999, Area = 20, NumberOfFloors = 1 };
            bool expected = false;
            //Act
            bool actual = house2.Filter(house1, house3);
            //Asseet
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterTest_for_Number_of_Floors()
        {
            //Arrange
            var house1 = new House() { Number = "", Region = "Киівська", Address = new Address { Street = "" }, Price = 1000, Area = 20, NumberOfFloors = 3 };
            var house2 = new House() { Number = "", Region = "Киівська", Address = new Address { Street = "" }, Price = 1000, Area = 20, NumberOfFloors = 2 };
            var house3 = new House() { Number = "", Region = "Киівська", Address = new Address { Street = "" }, Price = 1000, Area = 20, NumberOfFloors = 1 };
            bool expected = false;
            //Act
            bool actual = house2.Filter(house1, house3);
            //Asseet
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FilterTest_for_Region()
        {
            //Arrange
            var house1 = new House() { Number = "", Region = "Киівська", Address = new Address { Street = "" }, Price = 1000, Area = 20, NumberOfFloors = 1 };
            var house2 = new House() { Number = "", Region = "Вінницька", Address = new Address { Street = "" }, Price = 1000, Area = 20, NumberOfFloors = 1 };
            var house3 = new House() { Number = "", Region = "Чернівецька", Address = new Address { Street = "" }, Price = 1000, Area = 20, NumberOfFloors = 1 };
            bool expected = false;
            //Act
            bool actual = house2.Filter(house1, house3);
            //Asseet
            Assert.Equal(expected, actual);
        }
    }
}
