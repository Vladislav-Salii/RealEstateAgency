using Design;
using Xunit;

namespace RealEstateAgency.Tests
{

    public class FlatTests
    {
        [Fact]
        public void PricePerYear()
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
        public void AverageRoomArea()
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
    }


}
