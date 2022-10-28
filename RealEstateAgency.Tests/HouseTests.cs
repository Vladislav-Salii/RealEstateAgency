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
        public void FullName()
        {
            //Arrange


            string expected = "Вінницька Соборна";
            //Act
            var house = new House() { Number = "Будинок №1", Region = "Вінницька ", Address = new Address { Street = "Соборна" }, Price = 1000, Area = 100, NumberOfFloors = 1 };
            string actual = house.ReturnAddress();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
