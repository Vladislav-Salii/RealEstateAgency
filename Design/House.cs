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
        private const decimal PricePerSmeter = 30790.25M;
        const decimal MaxPercent = 0.05M;
        private bool OwnerIsVerified;
        public bool DocumentsAreVerified
        {
            get { return OwnerIsVerified; }
            set { OwnerIsVerified = value; }
        }

        public string Print()
        {
            return $"Область:{Region}Вулиця:{Address.Street}Номер будинку:{Number}Ціна:{Price}Площа:{Area}Кількість поверхів:{NumberOfFloors}";
        }

        public string Return_Address()
        {
            return $"{Region}{Address.Street}";
        }

        public decimal Purchase_Price(double Area, int NumOfFloors, decimal CorrectedPricePerMeter)
        {
            decimal Price;
            if (CorrectedPricePerMeter == 0)
            {
                Price = PricePerSmeter * NumOfFloors * (decimal)Area;
            }
            else
            {
                Price = CorrectedPricePerMeter * NumOfFloors * (decimal)Area;
            }

            return Price;
        }

        public decimal RieltorPart(decimal price, decimal correctingVal)
        {
            return price * correctingVal;
        }

        public decimal RealPrice(decimal price, decimal correctingVal)
        {
            return this.RieltorPart(price, correctingVal) + price;
        }

        public bool Purchasing(bool OwnerDocumentsAreVerified, decimal PurchasePrice, decimal RealPrice)
        {
            if (OwnerDocumentsAreVerified && RealPrice <= PurchasePrice * MaxPercent * PurchasePrice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Filter(object objFrom, object objTo)
        {
            House houseTo = objTo as House;
            House houseFrom = objFrom as House;

            if (houseTo == null || houseFrom == null)
            {
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
