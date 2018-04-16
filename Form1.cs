/*
 * Inventory Form
 * This program was written by Jason Borum
 * Date: April 1, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Initialize variables
            string category;
            string name;
            string number;
            decimal price;

            // Get variable from form
            category = txtCategory.Text;
            name = txtName.Text;
            number = txtNumber.Text;
            price = Convert.ToDecimal(txtPrice.Text);
            Inventory item1 = new Inventory(category, name, number, price);
            MessageBox.Show(string.Format("The new item added is {0}, {1}, {2}, {3} and there are a total of {4} items", item1.Category, item1.Name, item1.Number, item1.Price, item1.Quantity));

        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            // Create inventory objects
            Inventory item1 = new Inventory("Toy", "Water Gun", "2018-0971-WaterGun", 24.99m);
            Inventory item2 = new Inventory("Toy", "Teddy Bear", "2018-8802-Teddy", 29.99m);
            Inventory item3 = new Inventory("Toy", "Beach Ball", "2018-501-BeachBall", 2.99m);
            Inventory item4 = new Inventory("Clothing", "Blue Jeans", "2018-091-BlueJeans", 59.99m);
            Inventory item5 = new Inventory("Shoes", "BasketBall Shoe", "2018-24-BballShoe", 212.99m);
            Inventory item6 = new Inventory("Shoes", "Football Cleat", "2018-04-Cleat", 74.99m);
            Inventory item7 = new Inventory("Furniture", "Love Seat", "2018-07-LoveSeat", 984.99m);

            //Initilize inventory manager object
            InventoryManager cornerStore = new InventoryManager();

            //Add items objects to inventor manager class
            cornerStore.addItem(item1);
            cornerStore.addItem(item2);
            cornerStore.addItem(item3);
            cornerStore.addItem(item4);
            cornerStore.addItem(item5);
            cornerStore.addItem(item6);
            cornerStore.addItem(item7);

            //Display items after they were added
            Console.WriteLine("*****Display objects before items are removed*****");
            cornerStore.displayInventory();

            //Remove items from the inventor manager
            cornerStore.removeItem(item5);
            cornerStore.removeItem(item6);
            cornerStore.removeItem(item7);

            // Display items after some items were removed
            Console.WriteLine(" ");
            Console.WriteLine("*****Display objects after some items were removed*****");
            cornerStore.displayInventory();

            //Restock items method
            cornerStore.restockItem(item5, 5);

            // Display items after some items were restocked
            Console.WriteLine(" ");
            Console.WriteLine("*****Display objects after some items were restocked*****");
            cornerStore.displayInventory();
        }
    }
}
