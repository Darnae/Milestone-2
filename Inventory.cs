using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Darnae Simmons
// This is my own Work

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
            Inventory_ inventory = new Inventory_();

            inventory.Box();

           

            

           

        }
    }

    class Inventory_ // the inventory class
    {
        private string [] box;
  


     public Inventory_() // method for inventory 
        {
            box = new string[3];
        }

        public void Box() // properties for Inventory
        {
           
            box[0] = "Door Knobs ($19.50)";
            box[1] = "Pots and Pans ($30)";
            box[2] = "Lightbulbs ($9.50)";
          
            string item_one= box[0];
            string item_two= box[1];
            string item_three= box[2];

            MessageBox.Show("All Items Name and Price...");
            MessageBox.Show("Item One: " + item_one);
            MessageBox.Show("Item Two: " + item_two);
            MessageBox.Show("Item Three: " + item_three);

        }


        public string getBox()
        {
            return box.ToString();
        }


    }

}

