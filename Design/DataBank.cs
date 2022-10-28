using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
     public static class DataBank
    {
        static public string number;
        static public string region;
        static public string street;
        static public int price;
        static public double area;
        static public int numberOfFloors;
        static public int countOfRoom;

        static DataBank()
        {
            number = null;
            region = null;
            street = null;
            price = 0;
            area = 0.0;
            numberOfFloors = 0;
            countOfRoom = 0;  
            
        }
    }
}
