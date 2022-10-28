using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design.Forms.FlatsForms
{
    public partial class Flat_7 : Form
    {
        public Flat_7()
        {
            InitializeComponent();
        }

        private void Flat_7_Load(object sender, EventArgs e)
        {
            lbl_flat_1.Text = "Номер квартири : " + DataBank.number;
            lbl_flat_2.Text = "Область : " + DataBank.region;
            lbl_flat_3.Text = "Вулиця : " + DataBank.street;
            lbl_flat_4.Text = "Ціна : " + DataBank.price.ToString() + " $";
            lbl_flat_5.Text = "Площа : " + DataBank.area.ToString() + " м^2";
            lbl_flat_6.Text = "Кількість кімнат : " + DataBank.countOfRoom.ToString();
        }
    }
}
