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
    delegate List<T> ReadingList<T>(string path);
    public partial class FormFlats : Form
    {
        FileInAndOut<Flat> fileInAndOut = new FileInAndOut<Flat>();
        List<Flat> flats = new List<Flat>();
        List<Flat> sortedflats = new List<Flat>();
        List<Form> forms = new List<Form>() { new FlatsForms.Flat_1(),
                                              new FlatsForms.Flat_2(),
                                              new Flat_3(),
                                              new FlatsForms.Flat_4(),
                                              new FlatsForms.Flat_5(),
                                              new FlatsForms.Flat_6(),
                                              new FlatsForms.Flat_7(),
                                              new FlatsForms.Flat_8(),
                                              new FlatsForms.Flat_9(),
                                              


        };
        private int priceOfFlats;
        private int areaOfFlat;
        private int countOfFloar;
        private int wayOfRegion;

        public FormFlats()
        {
            InitializeComponent();
        }
       
        private void FormFlats_Load(object sender, EventArgs e)
        {
            List<Flat> temp_flats = new List<Flat>()
            {
                new Flat() { Number = "Квартира №1", Region = "Вінницька", Address = new Address { Street = "Лесі Українки" }, Price = 100, Area = 100, CountOfRoom = 3 },
                new Flat() { Number = "Квартира №2", Region = "Вінницька", Address = new Address { Street = "Шевченка" }, Price = 200, Area = 200, CountOfRoom = 2 },
                new Flat() { Number = "Квартира №3", Region = "Київська", Address = new Address { Street = "Жовтнева" }, Price = 180, Area = 180, CountOfRoom = 2 },
                new Flat() { Number = "Квартира №4", Region = "Київська", Address = new Address { Street = "Ломоносова" }, Price = 150, Area = 155, CountOfRoom = 3 },
                new Flat() { Number = "Квартира №5", Region = "Вінницька", Address = new Address { Street = "Толстого" }, Price = 250, Area = 250, CountOfRoom = 2 },
                new Flat() { Number = "Квартира №6", Region = "Київська", Address = new Address { Street = "Соборна" }, Price = 275, Area = 225, CountOfRoom = 3 },
                new Flat() { Number = "Квартира №7", Region = "Київська", Address = new Address { Street = "Ліни Костенко" }, Price = 187, Area = 236, CountOfRoom = 2 },
                new Flat() { Number = "Квартира №8", Region = "Вінницька", Address = new Address { Street = "Коцюбинського" }, Price = 198, Area = 245, CountOfRoom = 3 },
                new Flat() { Number = "Квартира №9", Region = "Київська", Address = new Address { Street = "Сковороди" }, Price = 205, Area = 218, CountOfRoom = 2 },
                new Flat() { Number = "Квартира №999", Region = "Київська", Address = new Address { Street = "Сковороди" }, Price = 155, Area = 210, CountOfRoom = 4 },

            };


            flats = temp_flats;

            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream(@"C:\Users\vlad\Desktop\Третій курс\Перший семестр\МРПЗ\RealEstateAgency\Design\Design\Files\Flats.bin", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, temp_flats);
            //}

            LoadTheme();
            //flats = InitFlat(fileInAndOut.ReadingFromFile);
            

        }
        private List<Flat> InitFlat(ReadingList<Flat> readingList)
        {           
            List<Flat> flats = readingList(@"C:\Users\vlad\Desktop\Третій курс\Перший семестр\МРПЗ\RealEstateAgency\Design\Design\Files\Flats.bin");

            if (flats == null)
            {
                MessageBox.Show("Не вдалося зчитати файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
                
            for (int i = 0; i < flats.Count; i++)
            {
                filteredBoxOfFlats.Items.Add($"{flats[i].Number}");
            }
            filteredBoxOfFlats.Items.Clear();
            return flats;
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
            lblArea.ForeColor = ThemeColor.SecondaryColor;
            lblPrice.ForeColor = ThemeColor.SecondaryColor;
            lblRegion.ForeColor = ThemeColor.SecondaryColor;
            lblRoom.ForeColor = ThemeColor.SecondaryColor;
            lblFrom.ForeColor = ThemeColor.SecondaryColor;
            lblTo.ForeColor = ThemeColor.SecondaryColor;
        }           
                

        private void EnteredPriceOfFlats_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(EnteredPriceOfFlats.Text, out priceOfFlats)))
            {
                priceOfFlats = 0;
            }
            else
            {
                priceOfFlats = int.Parse(EnteredPriceOfFlats.Text);
            }
        }
        private void EnteredAreaOfFlats_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(EnteredAreaOfFlats.Text, out areaOfFlat)))
            {
                areaOfFlat = 0;
            }
            else
            {
                areaOfFlat = int.Parse(EnteredAreaOfFlats.Text);
            }
        }
        private void EnteredFloatOfFlats_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(EnteredFloatOfFlats.Text, out countOfFloar)))
            {
                countOfFloar = 0;
            }
            else
            {
                countOfFloar = int.Parse(EnteredFloatOfFlats.Text);
            }
        }
        private void comboBoxOfRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            wayOfRegion = comboBoxOfRegion.SelectedIndex;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            filteredBoxOfFlats.Items.Clear();
            Flat flatFrom = new Flat();
            Flat flatTo = new Flat();
            int PriceOfFlatsFrom = 0;
            int PriceOfFlatsTo = 0;
            int FloatOfFlatsFrom = 0;
            int FloatOfFlatsTo = 0;
            int AreaOfFlatsFrom = 0;
            int AreaOfFlatsTo = 0;


            if ((EnteredPriceOfFlats.Text != "" && int.TryParse(EnteredPriceOfFlats.Text, out PriceOfFlatsFrom) == false) || (EnteredPriceOfFlatsTo.Text != "" && int.TryParse(EnteredPriceOfFlatsTo.Text, out PriceOfFlatsTo) == false))
            {
                MessageBox.Show("Неправильне введення ціни");
                return;
            }
            if (EnteredPriceOfFlats.Text != "" && EnteredPriceOfFlatsTo.Text != "" && PriceOfFlatsFrom > PriceOfFlatsTo)
            {
                MessageBox.Show("Неправильне введення ціни");
                return;
            }
            flatFrom.Price = PriceOfFlatsFrom;
            flatTo.Price = PriceOfFlatsTo;


            if ((EnteredAreaOfFlats.Text != "" && int.TryParse(EnteredAreaOfFlats.Text, out AreaOfFlatsFrom) == false) || (EnteredAreaOfFlatsTo.Text != "" && int.TryParse(EnteredAreaOfFlatsTo.Text, out AreaOfFlatsTo) == false))
            {
                MessageBox.Show("Неправильне введення площі");
                return;
            }
            if (EnteredAreaOfFlats.Text != "" && EnteredAreaOfFlatsTo.Text != "" && AreaOfFlatsFrom > AreaOfFlatsTo)
            {
                MessageBox.Show("Неправильне введення площі");
                return;
            }
            flatFrom.Area = AreaOfFlatsFrom;
            flatTo.Area = AreaOfFlatsTo;

            if ((EnteredFloatOfFlats.Text != "" && int.TryParse(EnteredFloatOfFlats.Text, out FloatOfFlatsFrom) == false) || (EnteredFloatOfFlatsTo.Text != "" && int.TryParse(EnteredFloatOfFlatsTo.Text, out FloatOfFlatsTo) == false))
            {
                MessageBox.Show("Неправильне введення кількості кімнат");
                return;
            }
            if (EnteredFloatOfFlats.Text != "" && EnteredFloatOfFlatsTo.Text != "" && FloatOfFlatsFrom > FloatOfFlatsTo)
            {
                MessageBox.Show("Неправильне введення кількості кімнат");
                return;
            }
            flatFrom.CountOfRoom = FloatOfFlatsFrom;
            flatTo.CountOfRoom = FloatOfFlatsTo;

            flatFrom.Region = comboBoxOfRegion.Text;
            flatTo.Region = comboBoxOfRegion.Text;

            foreach (var flat in flats)
            {
                if (flat.Filter(flatFrom, flatTo) == true)
                {
                    filteredBoxOfFlats.Items.Add(flat.Number);
                    sortedflats.Add(flat);
                }
            }             
        }
        private void AddInformOfFlats1_Click(object sender, EventArgs e)
        {

            Flat flatSearch = null;
            if (filteredBoxOfFlats.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть один із елементів ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < flats.Count; i++)
                {
                    if (flats[i].Number == filteredBoxOfFlats.SelectedItem.ToString())
                    {
                        flatSearch = flats[i];                        
                        break;
                    }
                }
                DataBank.number = flatSearch.Number;
                DataBank.region = flatSearch.Region;
                DataBank.street = flatSearch.Address.Street;
                DataBank.price = flatSearch.Price;
                DataBank.area = flatSearch.Area;
                DataBank.countOfRoom = flatSearch.CountOfRoom;

                forms[0].ShowDialog();

                //if (flatSearch.Number == "Квартира №1")
                //    forms[0].ShowDialog();
                //else if (flatSearch.Number == "Квартира №2")
                //    forms[1].ShowDialog();
                //else if (flatSearch.Number == "Квартира №3")
                //    forms[2].ShowDialog();
                //else if (flatSearch.Number == "Квартира №4")
                //    forms[3].ShowDialog();
                //else if (flatSearch.Number == "Квартира №5")
                //    forms[4].ShowDialog();
                //else if (flatSearch.Number == "Квартира №6")
                //    forms[5].ShowDialog();
                //else if (flatSearch.Number == "Квартира №7")
                //    forms[6].ShowDialog();
                //else if (flatSearch.Number == "Квартира №8")
                //    forms[7].ShowDialog();
                //else if (flatSearch.Number == "Квартира №9")
                //    forms[8].ShowDialog();

            }
            filteredBoxOfFlats.ClearSelected();
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\vlad\Desktop\Третій курс\Перший семестр\МРПЗ\RealEstateAgency\Design\Design\Result\SortedFlats.bin";
            string endpath = @"SortedFlats.bin";


            if (!sortedflats.Any() && sortedflats.Count == 0)
            {
                MessageBox.Show("Список не містить відсортованих елементів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (fileInAndOut.WritingToFile(path, sortedflats))
                {
                    MessageBox.Show("Відфільтрований список домів записаний у файл : \n\n" + endpath);
                }
                else
                {
                    MessageBox.Show("Не вдалося записати в файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (sortedflats.Count != 0)
            {
                sortedflats.Clear();
            }
        }


    }
}
