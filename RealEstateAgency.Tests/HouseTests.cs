﻿using Design;
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
        public void Purchasing_Condition()
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
    }
}