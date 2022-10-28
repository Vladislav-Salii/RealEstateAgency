using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    [Serializable]
    public class House : Realty, IPrintable, IFilter
    {
        public int NumberOfFloors { get; set; }
        ////////////////////////////////////////////////////////
        private const decimal PricePerSmeter = 30790.25M;
        const decimal MaxPercent = 0.05M;
        private bool OwnerIsVerified;
        public bool DocumentsAreVerified
        {
            get { return OwnerIsVerified; }
            set { OwnerIsVerified = value; }
        }

        ////////////////////////////////////////////////////////
        public string Print()
        {
            return "Номер будинку :" + Number +
                    "\nОбласть :" + Region +
                    "\nВулиця : " + Address.Street +
                    "\nЦіна :" + Price +
                    "\nПлоща :" + Area +
                    "\nКількість поверхів :" + NumberOfFloors;
        }

        ////////////////////////////////////////////////////////

        public string ReturnAddress()
        {
            return $"{Region}{Address.Street}";
        }

        public decimal Purchase_Price(double Area, int NumOfFloors)
        {

            return PricePerSmeter * NumOfFloors * (decimal)Area;
        }

        public decimal RieltorPart(int percent, int correctingVal)//3-5
        {

            return (decimal)percent / (100 * correctingVal);
        }

        public decimal RealPrice(double Area, int NumOfFloors, int percent, int correctingVal)
        {
            return this.RieltorPart(percent, correctingVal) + this.Purchase_Price(Area, NumOfFloors);
        }

        public bool Purchasing(bool OwnerDocumentsAreVerified, decimal PurchasePrice, decimal RealPrice)
        {
            if (OwnerDocumentsAreVerified && RealPrice < PurchasePrice * MaxPercent * PurchasePrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OwnerDocumentsVerified()
        {
            return DocumentsAreVerified;
        }

        ////////////////////////////////////////////////////////

        public bool Filter(object objFrom, object objTo)
        {
            House houseTo = objTo as House;
            House houseFrom = objFrom as House;

            if (houseTo == null || houseFrom == null)
            {
                MessageBox.Show("Неможлива фільтрація", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool check = true;
            if (houseFrom.Price == 0 && houseTo.Price == 0)
            {
                check = true;
            }
            else if (houseFrom.Price == 0 && this.Price <= houseTo.Price)
            {
                check = true;
            }
            else if (houseTo.Price == 0 && this.Price >= houseFrom.Price)
            {
                check = true;
            }
            else if (this.Price >= houseFrom.Price && this.Price <= houseTo.Price)
            {
                check = true;
            }
            else
            {
                return false;
            }

            if (houseFrom.Area == 0 && houseTo.Area == 0)
            {
                check = true;
            }
            else if (houseFrom.Area == 0 && this.Area <= houseTo.Area)
            {
                check = true;
            }
            else if (houseTo.Area == 0 && this.Area >= houseFrom.Area)
            {
                check = true;
            }
            else if (this.Area >= houseFrom.Area && this.Area <= houseTo.Area)
            {
                check = true;
            }
            else
            {
                return false;
            }

            if (houseFrom.NumberOfFloors == 0 && houseTo.NumberOfFloors == 0)
            {
                check = true;
            }
            else if (houseFrom.NumberOfFloors == 0 && this.NumberOfFloors <= houseTo.NumberOfFloors)
            {
                check = true;
            }
            else if (houseTo.NumberOfFloors == 0 && this.NumberOfFloors >= houseFrom.NumberOfFloors)
            {
                check = true;
            }
            else if (this.NumberOfFloors >= houseFrom.NumberOfFloors && this.NumberOfFloors <= houseTo.NumberOfFloors)
            {
                check = true;
            }
            else
            {
                return false;
            }

            if (houseFrom.Region == "" || houseFrom.Region == "Всі")
            {
                check = true;
            }
            else if (houseFrom.Region == this.Region)
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
