using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.Forms.HomeForms
{
    public partial class Home_6 : Form
    {
        public Home_6()
        {
            InitializeComponent();
        }

        private void Home_6_Load(object sender, EventArgs e)
        {
            lbl_house_1.Text = "Номер будинку : " + DataBank.number;
            lbl_house_2.Text = "Область : " + DataBank.region;
            lbl_house_3.Text = "Вулиця : " + DataBank.street;
            lbl_house_4.Text = "Ціна : " + DataBank.price.ToString() + "$";
            lbl_house_5.Text = "Площа : " + DataBank.area.ToString() + "м^2"; 
            lbl_house_6.Text = "Кількість поверхів : " + DataBank.numberOfFloors.ToString();

        }
    }
}
