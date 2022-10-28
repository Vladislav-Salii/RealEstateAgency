using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    [Serializable]
    public class Storage : Realty, IPrintable, IFilter
    {
        public string Print()
        {
            return "Номер складу :" + Number +
                    "\nОбласть :" + Region +
                    "\nВулиця : " + Address.Street +
                    "\nЦіна :" + Price +
                    "\nПлоща :" + Area;
        }
        public int PricePerYear()
        {
            return this.Price * 12;
        }
        public double SummArea(int AmountRooms)
        {
            return this.Area * AmountRooms;
        }
        public bool FilterNumber()
        {
            if (Number == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public string OurRegion()
        {
            return this.Region;
        }
        public bool Filter(object objFrom, object objTo)
        {
            Storage storageFrom = objFrom as Storage;
            Storage storageTo = objTo as Storage;

            if (storageFrom == null || storageTo == null)
            {
                MessageBox.Show("Неможлива фільтрація", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool check = true;
            if (storageFrom.Price == 0 && storageTo.Price == 0)
            {
                check = true;
            }
            else if (storageFrom.Price == 0 && this.Price <= storageTo.Price)
            {
                check = true;
            }
            else if (storageTo.Price == 0 && this.Price >= storageFrom.Price)
            {
                check = true;
            }
            else if (this.Price >= storageFrom.Price && this.Price <= storageTo.Price)
            {
                check = true;
            }
            else
            {
                return false;
            }

            if (storageFrom.Area == 0 && storageTo.Area == 0)
            {
                check = true;
            }
            else if (storageFrom.Area == 0 && this.Area <= storageTo.Area)
            {
                check = true;
            }
            else if (storageTo.Area == 0 && this.Area >= storageFrom.Area)
            {
                check = true;
            }
            else if (this.Area >= storageFrom.Area && this.Area <= storageTo.Area)
            {
                check = true;
            }
            else
            {
                return false;
            }

            if (storageFrom.Region == "" || storageFrom.Region == "Всі")
            {
                check = true;
            }
            else if (storageFrom.Region == this.Region)
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
