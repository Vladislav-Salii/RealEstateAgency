using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    [Serializable]
    public class Flat : Realty, IPrintable, IFilter
    {
        public List<string> State { get; set; }
        public Flat()
        {
            State = new List<string>
            {
                "Rended",
                "Free",
                "On sale",
                "Inaccessible"
            };
        }
        public int? Deposit { get; set; }
        public int CountOfRoom { get; set; }
        public int PricePerYear()
        {
            return Price * 12;
        }
        public double AverageRoomArea()
        {
            return (double)((Area*0.75) / CountOfRoom);
        }
        public bool CheckDeposit()
        {
            if (this.Deposit >= this.Price/10 && this.Deposit <= this.Price*0.15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Print()
        {
            return   $"Номер будинку : {Number} ," +
                     $" Область : {Region} ," +
                     $" Вулиця : {Address.Street} ," +
                     $" Ціна : {Price} ," +
                     $" Площа : {Area} ," +
                     $" Кількість поверхів : {CountOfRoom}";
                
        }
        public bool Filter(object objFrom, object objTo)
        {
            Flat flatFrom = objFrom as Flat;
            Flat flatTo = objTo as Flat;

            if (flatFrom == null || flatTo == null)
            {
                MessageBox.Show("Неможлива фільтрація", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool check = true;
            if (flatFrom.Price == 0 && flatTo.Price == 0)
            {
                check = true;
            }
            else if (flatFrom.Price == 0 && this.Price <= flatTo.Price)
            {
                check = true;
            }
            else if (flatTo.Price == 0 && this.Price >= flatFrom.Price)
            {
                check = true;
            }
            else if (this.Price >= flatFrom.Price && this.Price <= flatTo.Price)
            {
                check = true;
            }
            else
            {
                return false;
            }

            if (flatFrom.Area == 0 && flatTo.Area == 0)
            {
                check = true;
            }
            else if (flatFrom.Area == 0 && this.Area <= flatTo.Area)
            {
                check = true;
            }
            else if (flatTo.Area == 0 && this.Area >= flatFrom.Area)
            {
                check = true;
            }
            else if (this.Area >= flatFrom.Area && this.Area <= flatTo.Area)
            {
                check = true;
            }
            else
            {
                return false;
            }

            if (flatFrom.CountOfRoom == 0 && flatTo.CountOfRoom == 0)
            {
                check = true;
            }
            else if (flatFrom.CountOfRoom == 0 && this.CountOfRoom <= flatTo.CountOfRoom)
            {
                check = true;
            }
            else if (flatTo.CountOfRoom == 0 && this.CountOfRoom >= flatFrom.CountOfRoom)
            {
                check = true;
            }
            else if (this.CountOfRoom >= flatFrom.CountOfRoom && this.CountOfRoom <= flatTo.CountOfRoom)
            {
                check = true;
            }
            else
            {
                return false;
            }

            if (flatFrom.Region == "" || flatFrom.Region == "Всі")
            {
                check = true;
            }
            else if (flatFrom.Region == this.Region)
            {
                check = true;
            }
            else
            {
                return false;
            }
            return check;
        }
    }
}
