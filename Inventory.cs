using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Class
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Inventory_ inventory_ = new Inventory_();

            inventory_.Box();

            MessageBox.Show(inventory_.GetBox());

        }
    }

    class Inventory_
    {
        private string box;

        public Inventory_()
        {
            box = 0.ToString();
        }
      public void Box()
        {
            Random random = new Random(10);
            int[] array = new int[5];

           
            if (random.NextDouble() < 5)
            {
                array = new int[4]; 
            }

            if (random.NextDouble() < 20)
            {
                array = new int[10];
            }
               

            box = array.Length.ToString();
        }

        public string GetBox()
        {
            return box;
        }

    }
   
}

