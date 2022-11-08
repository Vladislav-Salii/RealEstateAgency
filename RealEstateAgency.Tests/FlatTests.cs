using Design;
using System;
using Xunit;

namespace RealEstateAgency.Tests
{

    public class FlatTests
    {
        [Fact]
        public void PricePerYear__PerMounth100Month12__Return1200()
        {
            //arrange
            int pricePerMonth = 100;
            int countOfMonth = 12;
            int expected = pricePerMonth * countOfMonth;
            //act
            Flat flat = new Flat() { Number = "Квартира №1", Region = "Вінницька", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 100, CountOfRoom = 3 };
            int actual = flat.PricePerYear();

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void PrintFullInfoAboutFlat()
        {
            //arrange
            string expected = "Номер будинку : Квартира №1 , Область : Вінницька , Вулиця : Лесі Українки , Ціна : 100 , Площа : 100 , Кількість поверхів : 3";

            //act
            Flat flat = new Flat() { Number = "Квартира №1", Region = "Вінницька", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 100, CountOfRoom = 3 };
            string actual = flat.Print();

            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void AverageRoomArea__Area100Rooms3__Return25()
        {
            //arrange
            double area = 100;
            int countOfRooms = 3;
            double coefficient = 0.75;
            double expected = (area * coefficient) / countOfRooms;

            //act
            Flat flat = new Flat() { Number = "Квартира №1", Region = "Вінницька", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 100, CountOfRoom = 3 };
            double actual = flat.AverageRoomArea();

            //assert
            Assert.Equal(expected, actual, 5);

        }

        [Theory]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(10)]
        public void Deposit_ShouldBeInRangeOf10to15Percent(object value)
        {

            //act
            Flat flat = new Flat() { Number = "Квартира №1", Region = "Вінницька", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 100, CountOfRoom = 3 };
            int actual = flat.CheckDeposit((int)value);

            //assert
            Assert.Equal(value, actual);

        }

        [Theory]
        [InlineData(46)]
        [InlineData(20)]
        public void DepositShouldBeInRangeOf10to15Percent_ReturnMinus1(int value)
        {

            //act
            Flat flat = new Flat() { Number = "Квартира №1", Region = "Вінницька", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 100, CountOfRoom = 3 };
            int actual = flat.CheckDeposit((int)value);

            //excepted
            int excepted = -1;

            //assert
            Assert.Equal(excepted, actual);

        }


        [Fact]
        public void CheckFilterOnNull_ReturnFalse()
        {
            //Arrange
            Flat flatform = new Flat() { Number = "Квартира №1", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 80, Area = 0, CountOfRoom = 0 };
            Flat flatthis = new Flat() { Number = "Квартира №3", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 0, CountOfRoom = 0 };
            bool actual = flatthis.Filter(null, flatform);

            //expected
            bool expected = false;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckFilterOnCastingTypes_ReturnFalse()
        {
            //Arrange
            Flat flatform = new Flat() { Number = "Квартира №1", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 80, Area = 0, CountOfRoom = 0 };
            Flat flatthis = new Flat() { Number = "Квартира №3", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 0, CountOfRoom = 0 };
            bool actual = flatthis.Filter(new DateTime(), flatform);

            //expected
            bool expected = false;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckFilterOnPrice_PriceMore80AndLess120_ReturnTrue()
        {
            //Arrange
            Flat flatform = new Flat() { Number = "Квартира №1", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 80, Area = 0, CountOfRoom = 0 };
            Flat flatto= new Flat() { Number = "Квартира №2", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 125, Area = 0, CountOfRoom = 0 };
            Flat flatthis = new Flat() { Number = "Квартира №3", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 0, CountOfRoom = 0 };
            bool actual = flatthis.Filter(flatform, flatto);

            //expected
            bool expected = true;

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CheckFilterOnArea_AreaMore75AndLess150_ReturnTrue()
        {
            //Arrange
            Flat flatform = new Flat() { Number = "Квартира №1", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 0, Area = 75, CountOfRoom = 0 };
            Flat flatto = new Flat() { Number = "Квартира №2", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 0, Area = 150, CountOfRoom = 0 };
            Flat flatthis = new Flat() { Number = "Квартира №3", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 0, Area = 100, CountOfRoom = 0 };
            bool actual = flatthis.Filter(flatform, flatto);

            //expected
            bool expected = true;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckFilterOnCountOfRoom_CountOfRoomMore1AndLess4_ReturnTrue()
        {
            //Arrange
            Flat flatform = new Flat() { Number = "Квартира №1", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 0, Area = 0, CountOfRoom = 1 };
            Flat flatto = new Flat() { Number = "Квартира №2", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 0, Area = 0, CountOfRoom = 4 };
            Flat flatthis = new Flat() { Number = "Квартира №3", Region = "", Address = new Address { Street = "Лесі Українки" }, Price = 0, Area = 0, CountOfRoom = 2 };
            bool actual = flatthis.Filter(flatform, flatto);

            //expected
            bool expected = true;

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CheckFilterOnRegion()
        {
            //Arrange
            Flat flatform = new Flat() { Number = "Квартира №1", Region = "Вінниця", Address = new Address { Street = "Лесі Українки" }, Price = 0, Area = 0, CountOfRoom = 0 };
            Flat flatto = new Flat() { Number = "Квартира №2", Region = "Київ", Address = new Address { Street = "Лесі Українки" }, Price = 0, Area = 0, CountOfRoom = 0 };
            Flat flatthis = new Flat() { Number = "Квартира №3", Region = "Хмельницький", Address = new Address { Street = "Лесі Українки" }, Price = 0, Area = 0, CountOfRoom = 0 };
            bool actual = flatthis.Filter(flatform, flatto);

            //expected
            bool expected = false;

            //Assert
            Assert.Equal(expected, actual);
        }

    }


}
