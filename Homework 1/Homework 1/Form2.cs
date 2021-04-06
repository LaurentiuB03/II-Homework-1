using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Homework_1.Form1;


namespace Homework_1
{
    public partial class Form2 : Form
    {
        bool check = true;

        public bool getCheck()
        {
            return check;
        }
        
        public void setCheck(bool check)
        {
            this.check = check;
            
        }
        public Form2()
        {
            InitializeComponent();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (CashBtn.Checked)
                {
                    MessageBox.Show("Comanda a fost plasata. Ati selectat plata cu cash!");
                    listBox1.Items.Clear();
                    setCheck(false);
                    TotalPriceTextBox.Text = string.Empty;
                    this.Close();
                }
                else if (CardBtn.Checked)
                {
                    MessageBox.Show("Comanda a fost plasata. Ati selectat plata cu cardul!");
                    listBox1.Items.Clear();
                    setCheck(false);
                    TotalPriceTextBox.Text = string.Empty;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Va rugam selectati modalitatea de plata!");
                }
            }
            else
            {
                MessageBox.Show("Nu ati adaugat nici un produs in cos!");
            }

            
        }
    }
}
