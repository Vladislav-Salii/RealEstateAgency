using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{   
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            btnClose.Visible = false;
        }
        
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender!=null)
            {
                if (currentButton!=(Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    btnClose.Visible = true;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }        
        }

        private void OpenChildForm(Form childForm , object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            btnClose.Visible = true;
        }


        private void btnHouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHouses(),sender);
        }

        private void btnFlat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFlats(), sender);
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStorage(), sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (activateForm !=null)
            {
                activateForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Home";
            panelTitle.BackColor = Color.FromArgb(0,150,136);
            panelLogo.BackColor = Color.FromArgb(39,39,58);
            btnClose.Visible = false;        
        }


    }
}
