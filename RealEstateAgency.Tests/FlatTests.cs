using Design;
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
        [InlineData(46)]
        public void Deposit_ShouldBeInRangeOf10to15Percent(object value)
        {

            //act
            Flat flat = new Flat() { Number = "Квартира №1", Region = "Вінницька", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 100, CountOfRoom = 3 };
            int actual = flat.CheckDeposit((int)value);

            //assert
            Assert.Equal(value, actual);

        }

        [Fact]
        public void State_HaveFree()
        {
            //Arrange
            var sut = new Flat();
            string expected = "Free";

            //Assert
            Assert.Contains(expected, sut.State);
        }

    }


}
