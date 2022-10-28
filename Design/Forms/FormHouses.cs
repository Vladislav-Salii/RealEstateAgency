using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.Forms
{
    
    public partial class FormHouses : Form
    {
        FileInAndOut<House> fileInAndOut = new FileInAndOut<House>();
        List<House> houses = new List<House>();
        List<House> sortedhouses = new List<House>();
        List<Form> forms = new List<Form>() { new HomeForms.Home_1(),
                                              new HomeForms.Home_2(),
                                              new HomeForms.Home_3(),
                                              new HomeForms.Home_4(),
                                              new HomeForms.Home_5(),
                                              new HomeForms.Home_6(),
                                              new HomeForms.Home_7(),
                                              new HomeForms.Home_8(),
                                              new HomeForms.Home_9(),
                                              new HomeForms.Home_10()
        };
        private int priceOfHouse;
        private int areaOfHouse;
        private int countOfFloar;
        private int wayOfRegion;
        
        public FormHouses()
        {
            InitializeComponent();
        }
        private void FormHouses_Load(object sender, EventArgs e)
        {
            //List<House> temp_houses = new List<House>()
            //{
            //    new House() { Number = "Будинок №1", Region = "Вінницька", Address = new Address { Street = "Соборна " }, Price = 1000, Area = 100, NumberOfFloors = 1 },
            //    new House() { Number = "Будинок №2", Region = "Вінницька", Address = new Address { Street = "Івана-Франка " }, Price = 2000, Area = 150, NumberOfFloors = 2 },
            //    new House() { Number = "Будинок №3", Region = "Київська", Address = new Address { Street = "Янгеля " }, Price = 800, Area = 80, NumberOfFloors = 1 },
            //    new House() { Number = "Будинок №4", Region = "Вінницька", Address = new Address { Street = "Соборна " }, Price = 1400, Area = 120, NumberOfFloors = 2 },
            //    new House() { Number = "Будинок №5", Region = "Київська", Address = new Address { Street = "Пестеля " }, Price = 750, Area = 95, NumberOfFloors = 1 },
            //    new House() { Number = "Будинок №6", Region = "Київська", Address = new Address { Street = "Лесі Українки " }, Price = 820, Area = 75, NumberOfFloors = 2 },
            //    new House() { Number = "Будинок №7", Region = "Вінницька", Address = new Address { Street = "Сковороди " }, Price = 990, Area = 90, NumberOfFloors = 2 },
            //    new House() { Number = "Будинок №8", Region = "Вінницька", Address = new Address { Street = "Шевченка" }, Price = 995, Area = 92, NumberOfFloors = 1 },
            //    new House() { Number = "Будинок №9", Region = "Київська", Address = new Address { Street = "Коцюбинського" }, Price = 810, Area = 85, NumberOfFloors = 2 },
            //    new House() { Number = "Будинок №10", Region = "Вінницька", Address = new Address { Street = "Загірна" }, Price = 840, Area = 85, NumberOfFloors = 1 },

            //};

            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream(@"C:\Users\codex\source\repos\RealtyEstatyAgency\Design\Files\House.bin", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, temp_houses);
            //}

            LoadTheme();
            houses = InitHouse(fileInAndOut.ReadingFromFile);
        }
        private List<House> InitHouse(ReadingList<House> readingList)
        {
            List<House> houses = readingList(@"C:\Users\vlad\Desktop\Третій курс\Перший семестр\МРПЗ\RealEstateAgency\Design\Design\Files\House.bin");
            if (houses == null)
            {
                MessageBox.Show("Не вдалося зчитати файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }                
            for (int i = 0; i < this.houses.Count; i++)
            {
                filteredBoxOfHouse.Items.Add($"{this.houses[i].Number}");
            }
            filteredBoxOfHouse.Items.Clear();
            return houses;
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
          
            lblPrice.ForeColor = ThemeColor.SecondaryColor;
            lblArea.ForeColor = ThemeColor.SecondaryColor;
            lblRegion.ForeColor = ThemeColor.SecondaryColor;
            lblFloat.ForeColor = ThemeColor.SecondaryColor;
            lblFrom.ForeColor = ThemeColor.SecondaryColor;
            lblTo.ForeColor = ThemeColor.SecondaryColor;

        }       
        private void EnteredPriceOfHouse_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(EnteredPriceOfHouse.Text, out priceOfHouse)))
            {
                priceOfHouse = 0;
            }
            else
            {
                priceOfHouse = int.Parse(EnteredPriceOfHouse.Text);
            }
        }
        private void EnteredAreaOfHouse_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(EnteredAreaOfHouse.Text, out areaOfHouse)))
            {
                areaOfHouse = 0;
            }
            else
            {
                areaOfHouse = int.Parse(EnteredAreaOfHouse.Text);
            }
        }
        private void EnteredFloatOfHouse_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(EnteredFloarOfHouse.Text, out countOfFloar)))
            {
                countOfFloar = 0;
            }
            else
            {
                countOfFloar = int.Parse(EnteredFloarOfHouse.Text);
            }
            
        }
        private void comboBoxOfRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            wayOfRegion = comboBoxOfRegion.SelectedIndex;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            filteredBoxOfHouse.Items.Clear();
            House houseFrom = new House();
            House houseTo = new House();
            int PriceOfHousesFrom = 0;
            int PriceOfHousesTo = 0;
            int AreaOfHouseFrom = 0;
            int AreaOfHousesTo = 0;
            int FloarOfHouseFrom = 0;
            int FloarOfHouseTo = 0;

            if ((EnteredPriceOfHouse.Text != "" && int.TryParse(EnteredPriceOfHouse.Text, out PriceOfHousesFrom) == false) || (EnteredPriceOfHouseTo.Text != "" && int.TryParse(EnteredPriceOfHouseTo.Text, out PriceOfHousesTo) == false))
            {
                MessageBox.Show("Неправильне введення ціни");
                return;
            }
            if (EnteredPriceOfHouse.Text != "" && EnteredPriceOfHouseTo.Text != "" && PriceOfHousesFrom > PriceOfHousesTo)
            {
                MessageBox.Show("Неправильне введення ціни");
                return;
            }
            houseFrom.Price = PriceOfHousesFrom;
            houseTo.Price = PriceOfHousesTo;


            if ((EnteredAreaOfHouse.Text != "" && int.TryParse(EnteredAreaOfHouse.Text, out AreaOfHouseFrom) == false) || (EnteredAreaOfHouseTo.Text != "" && int.TryParse(EnteredAreaOfHouseTo.Text, out AreaOfHousesTo) == false))
            {
                MessageBox.Show("Неправильне введення площі");
                return;
            }
            if (EnteredAreaOfHouse.Text != "" && EnteredAreaOfHouseTo.Text != "" && AreaOfHouseFrom > AreaOfHousesTo)
            {
                MessageBox.Show("Неправильне введення площі");
                return;
            }
            houseFrom.Area = AreaOfHouseFrom;
            houseTo.Area = AreaOfHousesTo;

            if ((EnteredFloarOfHouse.Text != "" && int.TryParse(EnteredFloarOfHouse.Text, out FloarOfHouseFrom) == false) || (EnteredFloatOfHouseTo.Text != "" && int.TryParse(EnteredFloatOfHouseTo.Text, out FloarOfHouseTo) == false))
            {
                MessageBox.Show("Неправильне введення кількості поверхів");
                return;
            }
            if (EnteredFloarOfHouse.Text != "" && EnteredFloatOfHouseTo.Text != "" && FloarOfHouseFrom > FloarOfHouseTo)
            {
                MessageBox.Show("Неправильне введення кількості поверхів");
                return;
            }
            houseFrom.NumberOfFloors = FloarOfHouseFrom;
            houseTo.NumberOfFloors = FloarOfHouseTo;

            houseFrom.Region = comboBoxOfRegion.Text;
            houseTo.Region = comboBoxOfRegion.Text;

            foreach (var house in houses)
            {
                if (house.Filter(houseFrom, houseTo) == true)
                {
                    filteredBoxOfHouse.Items.Add(house.Number);
                    sortedhouses.Add(house);
                }
            }
        }
        private void addInformOfHouse_Click(object sender, EventArgs e)
        {
            House houseSearch = null;
            if (filteredBoxOfHouse.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть один із елементів ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < houses.Count; i++)
                {
                    if (houses[i].Number == filteredBoxOfHouse.SelectedItem.ToString())
                    {
                        houseSearch = houses[i];
                        break;
                    }
                }
                DataBank.number = houseSearch.Number;
                DataBank.region = houseSearch.Region;
                DataBank.street = houseSearch.Address.Street;
                DataBank.price = houseSearch.Price;
                DataBank.area = houseSearch.Area;
                DataBank.numberOfFloors = houseSearch.NumberOfFloors;                

               if (houseSearch.Number == "Будинок №1")
                    forms[0].ShowDialog();
                else if (houseSearch.Number == "Будинок №2")
                    forms[1].ShowDialog();
                else if (houseSearch.Number == "Будинок №3")
                    forms[2].ShowDialog();
                else if (houseSearch.Number == "Будинок №4")
                    forms[3].ShowDialog();
                else if (houseSearch.Number == "Будинок №5")
                    forms[4].ShowDialog();
                else if (houseSearch.Number == "Будинок №6")
                    forms[5].ShowDialog();
                else if (houseSearch.Number == "Будинок №7")
                    forms[6].ShowDialog();
                else if (houseSearch.Number == "Будинок №8")
                    forms[7].ShowDialog();
                else if (houseSearch.Number == "Будинок №9")
                    forms[8].ShowDialog();
                else if (houseSearch.Number == "Будинок №10")
                    forms[9].ShowDialog();

            }
            filteredBoxOfHouse.ClearSelected();
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\vlad\Desktop\Третій курс\Перший семестр\МРПЗ\RealEstateAgency\Design\Design\Result\SortedHouse.bin";
            string endpath = @"SortedHouse.bin";

            if (!sortedhouses.Any() && sortedhouses.Count==0)
            {
                MessageBox.Show("Список не містить нових відсортованих елементів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {        

                if (fileInAndOut.WritingToFile(path, sortedhouses))
                {
                    MessageBox.Show("Відфільтрований список домів записаний у файл : \n\n" + endpath);
                }
                else
                {
                    MessageBox.Show("Не вдалося записати в файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (sortedhouses.Count != 0)
                {
                    sortedhouses.Clear();
                }
               
            }
        }
    }
}
