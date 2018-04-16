/*
 * Inventory Manager class
 * This program was written by Jason Borum
 * Date: April 15, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    class InventoryManager
    {
        // Initilize inventoryManagerList
        private List<Inventory> inventoryManagerList = new List<Inventory>();

        // Start additem method
        public void addItem(Inventory item)
        {
            this.inventoryManagerList.Add(item);
        } // end of add item method

        //Start removeItem method
        public void removeItem(Inventory item)
        {
            this.inventoryManagerList.Remove(item);
        } // end of remove item method

        // starte restockItem method
        public void restockItem(Inventory item, int quantity)
        {
            int index = 0;
            // if quantity is greater than 0 then enter the loop
            if (quantity > 0)
            {
                // start while loop to add the number of items determined by the quantity
                while (index < quantity)
                {
                    this.inventoryManagerList.Add(item);
                    index++;
                } // end of while loop
            } // end of iff statement
        } // End of restock item method

        public void displayInventory()
        {
            //Cycle through each product in the list
            foreach(Inventory product in this.inventoryManagerList)
            {
                Console.WriteLine("Catergory = " + product.Category + ", Name = " + product.Name + ", Price = " + product.Price);

            } // end of foreach statement
        } //end of display Inventory Method

        //Method to search for by item name
        public List<int> searchName(string objectName)
        {
            //Declare list to store positions
            List<int> itemPosition = new List<int>();

            //cycle through each item in the inventory manager list
            foreach(Inventory item in this.inventoryManagerList)
            {
                //test to see if strings are equal and ignore case
                if (String.Equals(item.Name, objectName, StringComparison.OrdinalIgnoreCase))
                {
                    //if strings are equal add the item position to the list
                    itemPosition.Add(this.inventoryManagerList.IndexOf(item));
                } //end of if
            } // end of foreach
            return itemPosition;
        } // End of search name

        //Method to search by item price
        public List<int> searchPrice(decimal objectPrice)
        {
            //Declare list to store positions
            List<int> itemPosition = new List<int>();

            //cycle through each item in the inventory manager list
            foreach (Inventory item in this.inventoryManagerList)
            {
                //Test if prices match
                if (item.Price == objectPrice)
                {
                    //if prices match then add item position to list
                    itemPosition.Add(this.inventoryManagerList.IndexOf(item));
                } // end of if
            } // end of foreach statement

            //Return list of item positions
            return itemPosition;
        } // End of search name

    } // End of InventoryManager Class
} // End of namespace
