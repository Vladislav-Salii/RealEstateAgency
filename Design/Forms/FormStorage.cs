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
    public partial class FormStorage : Form
    {
        FileInAndOut<Storage> fileInAndOut = new FileInAndOut<Storage>();
        List<Storage> storages = new List<Storage>();
        List<Storage> sortedstorages = new List<Storage>();
        private int priceOfStorage;
        private int areaOfStorage;
        private int wayOfRegion;

        public FormStorage()
        {
            InitializeComponent();
            
        }
        private void FormStorage_Load(object sender, EventArgs e)
        {

            //List<Storage> storages = new List<Storage>()
            //{
            //    new Storage() { Number = "Склад №1", Region = "Вінницька", Address = new Address() { Street = "Богдана Хмельницького" }, Area = 100, Price = 200 },
            //    new Storage() { Number = "Склад №2", Region = "Вінницька", Address = new Address() { Street = "Лесі Українки" }, Area = 200, Price = 300 },
            //    new Storage() { Number = "Склад №3", Region = "Вінницька", Address = new Address() { Street = "Василя Стуса" }, Area = 300, Price = 400 },
            //    new Storage() { Number = "Склад №4", Region = "Київська", Address = new Address() { Street = "Валер'яна Підмогильного" }, Area = 400, Price = 500 },
            //    new Storage() { Number = "Склад №5", Region = "Вінницька", Address = new Address() { Street = "Соборна" }, Area = 500, Price = 600 }
            //};
            
            


            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream(@"C:\Users\codex\source\repos\RealtyEstatyAgency\Design\Files\Storages.bin", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, storages);
            //}

            LoadTheme();
            storages = InitStorage(fileInAndOut.ReadingFromFile);
        }

        private List<Storage> InitStorage(ReadingList<Storage> readingList)
        {

            List<Storage> storages = readingList(@"C:\Users\vlad\Desktop\Третій курс\Перший семестр\МРПЗ\RealEstateAgency\Design\Design\Files\Storages.bin");

            if (storages == null)
            {
                MessageBox.Show("Не вдалося зчитати файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
               

            for (int i = 0; i < storages.Count; i++)
            {
                filteredBoxOfStorage.Items.Add($"{storages[i].Number}");
            }
            filteredBoxOfStorage.Items.Clear();
            return storages;
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
            lblFrom.ForeColor = ThemeColor.SecondaryColor;
            lblTo.ForeColor = ThemeColor.SecondaryColor;
           
        }    
       
        
        

        private void EnteredPriceOfStorage_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(EnteredPriceOfStorage.Text, out priceOfStorage)))            
                priceOfStorage = 0;            
            else            
                priceOfStorage = int.Parse(EnteredPriceOfStorage.Text);
            
        }
        private void EnteredAreaOfStorage_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(EnteredAreaOfStorage.Text, out areaOfStorage)))
                areaOfStorage = 0;
            else
                areaOfStorage = int.Parse(EnteredAreaOfStorage.Text);
        }
        private void comboBoxOfRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            wayOfRegion = comboBoxOfRegion.SelectedIndex;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            filteredBoxOfStorage.Items.Clear();
            Storage storageFrom = new Storage();
            Storage storageTo = new Storage();
            int PriceOfStorageFrom = 0;
            int PriceOfStorageTo = 0;
            int AreaOfStorageTo = 0;
            int AreaOfStorageFrom = 0;

            if ((EnteredPriceOfStorage.Text != "" && int.TryParse(EnteredPriceOfStorage.Text, out PriceOfStorageFrom) == false) || (EnteredPriceOfStorageTo.Text != "" && int.TryParse(EnteredPriceOfStorageTo.Text, out PriceOfStorageTo) == false))
            {
                MessageBox.Show("Неправильне введення ціни");
                return;
            }
            if (EnteredPriceOfStorage.Text != "" && EnteredPriceOfStorageTo.Text != "" && PriceOfStorageFrom > PriceOfStorageTo)
            {
                MessageBox.Show("Неправильне введення ціни");
                return;
            }
            storageFrom.Price = PriceOfStorageFrom;
            storageTo.Price = PriceOfStorageTo;


            if ((EnteredAreaOfStorage.Text != "" && int.TryParse(EnteredAreaOfStorage.Text, out AreaOfStorageFrom) == false) || (EnteredAreaOfStorageTo.Text != "" && int.TryParse(EnteredAreaOfStorageTo.Text, out AreaOfStorageTo) == false))
            {
                MessageBox.Show("Неправильне введення площі");
                return;
            }
            if (EnteredAreaOfStorage.Text != "" && EnteredAreaOfStorageTo.Text != "" && AreaOfStorageFrom > AreaOfStorageTo)
            {
                MessageBox.Show("Неправильне введення площі");
                return;
            }
            storageFrom.Area = AreaOfStorageFrom;
            storageTo.Area = AreaOfStorageTo;

            storageFrom.Region = comboBoxOfRegion.Text;
            storageTo.Region = comboBoxOfRegion.Text;

            foreach (var storage in storages)
            {
                if (storage.Filter(storageFrom, storageTo) == true)
                {
                    filteredBoxOfStorage.Items.Add(storage.Number);
                    sortedstorages.Add(storage);
                }
            }

        }

        private void addInformOfStorage1_Click(object sender, EventArgs e)
        {
            Storage storageSearch = null;
            if (filteredBoxOfStorage.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть один із елементів ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < storages.Count; i++)
                {
                    if (storages[i].Number == filteredBoxOfStorage.SelectedItem.ToString())
                    {
                        storageSearch = storages[i];
                        break;
                    }
                }
                MessageBox.Show(storageSearch.Print());

            }
            filteredBoxOfStorage.ClearSelected();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {

            string path = @"C:\Users\vlad\Desktop\Третій курс\Перший семестр\МРПЗ\RealEstateAgency\Design\Design\Result\SortedStorage.bin";
            string endpath = @"SortedStorage.bin";

            if (!sortedstorages.Any() && sortedstorages.Count == 0)
            {
                MessageBox.Show("Список не містить відсортованих елементів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {             

                if (fileInAndOut.WritingToFile(path, sortedstorages))
                {
                    MessageBox.Show("Відфільтрований список домів записаний у файл : \n\n" + endpath);
                }
                else
                {
                    MessageBox.Show("Не вдалося записати в файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (sortedstorages.Count != 0)
                {
                    sortedstorages.Clear();
                }
            }
        }
    }
}
