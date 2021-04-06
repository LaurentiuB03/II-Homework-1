using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            quantity--;
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
            quantity--;
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
            quantity--;
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
            quantity--;
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
            quantity--;
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
            quantity--;
            BackpackText.Text = Convert.ToString(quantity);
        }
        #endregion
    }
}
