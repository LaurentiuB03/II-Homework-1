using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework_1.Form2;

namespace Homework_1
{   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int total_price=0;
        Form2 f = new Form2();
   

        bool any_btn_checked = false;
        #region Quantity increment and decrement buttons
        private void IncBoot_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(BootText.Text);
            quantity++;
            BootText.Text = Convert.ToString(quantity);
        }

        private void DecBoot_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(BootText.Text);
            if (quantity >= 1)
            {
                quantity--;
            }
            BootText.Text = Convert.ToString(quantity);
        }

        private void IncPants_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(PantsText.Text);
            quantity++;
            PantsText.Text = Convert.ToString(quantity);
        }

        private void DecPants_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(PantsText.Text);
            if (quantity >= 1)
            {
                quantity--;
            }
            PantsText.Text = Convert.ToString(quantity);
        }

        private void IncTshirt_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(TshirtText.Text);
            quantity++;
            TshirtText.Text = Convert.ToString(quantity);
        }

        private void DecShirt_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(TshirtText.Text);
            if (quantity >= 1)
            {
                quantity--;
            }
            TshirtText.Text = Convert.ToString(quantity);
        }

        private void IncBag_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(BagText.Text);
            quantity++;
            BagText.Text = Convert.ToString(quantity);
        }

        private void DecBag_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(BagText.Text);
            if (quantity >= 1)
            {
                quantity--;
            }
            BagText.Text = Convert.ToString(quantity);
        }

        private void IncShades_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(ShadesText.Text);
            quantity++;
            ShadesText.Text = Convert.ToString(quantity);
        }

        private void DecShades_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(ShadesText.Text);
            if (quantity >= 1)
            {
                quantity--;
            }
            ShadesText.Text = Convert.ToString(quantity);

        }

        private void IncBackpack_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(BackpackText.Text);
            quantity++;
            BackpackText.Text = Convert.ToString(quantity);
        }

        private void DecBackpack_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(BackpackText.Text);
            if (quantity >= 1)
            {
                quantity--;
            }
            BackpackText.Text = Convert.ToString(quantity);
        }
        #endregion

        #region Add to cart buttons
        public void AddBootBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            any_btn_checked = true;
            int quantity = int.Parse(BootText.Text);
            MessageBox.Show("Ati adaugat " + quantity + " perechi de bocanci in cos");
            total_price += int.Parse(BootPrice.Text)*quantity;
            int price = int.Parse(BootPrice.Text);
            if (!flag)
            {
                f.listBox1.Items.Add("Bocanci Scarpa, marimea 42    x" + quantity + "    " + price*quantity + " RON");
            }

        }

        public void AddPantsBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            any_btn_checked = true;
            int quantity = int.Parse(PantsText.Text);
            MessageBox.Show("Ati adaugat " + quantity + " perechi de pantaloni in cos");
            total_price += int.Parse(PantsPrice.Text) * quantity;
            int price = int.Parse(PantsPrice.Text);
            if (!flag)
            {
                f.listBox1.Items.Add("Pantaloni Salomon, M    x" + quantity + "    " + price * quantity + " RON");
            }
        }

        public void AddTshirtBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            any_btn_checked = true;
            int quantity = int.Parse(TshirtText.Text);
            MessageBox.Show("Ati adaugat " + quantity + " tricouri in cos");
            total_price += int.Parse(TshirtPrice.Text) * quantity;
            int price = int.Parse(TshirtPrice.Text);
            if (!flag)
            {
                f.listBox1.Items.Add("Tricou The North Face, M    x" + quantity + "    " + price * quantity + " RON");
            }
        }

        public void AddBagBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            any_btn_checked = true;
            int quantity = int.Parse(BagText.Text);
            MessageBox.Show("Ati adaugat " + quantity + " saci de dormit");
            total_price += int.Parse(BagPrice.Text) * quantity;
            int price = int.Parse(BagPrice.Text);
            if (!flag)
            {
                f.listBox1.Items.Add("Sac de dormit Pinguin    x" + quantity + "    " + price * quantity + " RON");
            }
        }

        public void AddShadesBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            any_btn_checked = true;
            int quantity = int.Parse(ShadesText.Text);
            MessageBox.Show("Ati adaugat " + quantity + " perechi de ochelari in cos");
            total_price += int.Parse(ShadesPrice.Text) * quantity;
            int price = int.Parse(ShadesPrice.Text);
            if (!flag)
            {
                f.listBox1.Items.Add("Ochelari de soare    x" + quantity + "    " + price * quantity + " RON");
            }
        }

        public void AddBackpackBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            any_btn_checked = true;
            int quantity = int.Parse(BackpackText.Text);
            MessageBox.Show("Ati adaugat " + quantity + " rucsacuri in cos");
            total_price += int.Parse(BackpackPrice.Text) * quantity;
            int price = int.Parse(BackpackPrice.Text);
            if (!flag)
            {
                f.listBox1.Items.Add("Rucsac Northfinder    x" + quantity + "    " + price * quantity + " RON");
            }
        }
        #endregion

        private void FinishOrderBtn_Click(object sender, EventArgs e)
        {
            
            if (!any_btn_checked)
            {
                MessageBox.Show("Nu ati adaugat in cos nici un produs");
            }
            else
            {
               
                
                    f.TotalPriceTextBox.Text = total_price + " RON";
                    any_btn_checked = false;
                    f.ShowDialog();
                if (!f.getCheck())
                    total_price = 0;
                
                
                
                    
                
            }
            
        }

        

        
    }
}
