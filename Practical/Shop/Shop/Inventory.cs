//=============================================================================
// Program's Inventory class
//=============================================================================

using System;

namespace Shop
{
    class Inventory
    {
        // TODO: Define three member fields
        //       An int called mMaxSize
        //       An array of Items called mItems
        //       An int called mGold

        private const int maxSize = 10;
        private Shop[] itemsArray = new Shop[10];
        private int theGold = 0;


        // TODO: Write a default constructor that assigns the mMaxSize to 10,
        //       mItems to a new array of Items with mMaxSize as the size,
        //       and mGold to 50.


        // TODO: Write a C# property for mGold called Gold (it has to
        //       access/update the mGold member field).

        public int GetGold()
        {
            return theGold; 
        }

        public void SetGold(int gold)
        {
            theGold = gold;
        }


        // TODO: Write a method called AddItem that returns a bool and takes an Item parameter.
        //       This method should iterate through the mItems array, looking for any array element
        //       that is null. If a null Item is found, it should assign that array element to the
        //       Item passed in and return true. Otherwise it should return false.

        public bool AddItem(Shop toAdd)
        {
            for(int i = 0; i < 10; i++)
            {
                if(itemsArray[i] == null)
                {
                    itemsArray[i] = toAdd;
                    return true;
                }
            }
            return false;
        }

        // TODO: Write a method called RemoveItem that returns a bool and takes a string parameter.
        //       This method should iterate through the mItems array, looking for an Item that
        //       has the same name as the parameter. If it finds a match it should set that 
        //       element of the mItems array to null and return true. Otherwise return false.
        //       Do not forget to make sure the element is not null before checking its name.

        public bool RemoveItem(string name)
        {
            for(int i = 0; i < 10; i++)
            {
                if((itemsArray[i] != null) && (name == itemsArray[i].GetName()))
                {
                    itemsArray[i] = null;
                    return true;
                }
            }
            return false;
        }

        // TODO: Write a method called GetItem that returns an Item and takes a string parameter.
        //       This method should iterate through the mItems array, looking for an Item that
        //       has the same name as the parameter. If it finds a match it should return that element 
        //       of the mItems array. Otherwise return null.
        //       Do not forget to make sure the element is not null before checking its name.

        public Shop GetItem(string name)
        {
            for(int i = 0; i < 10; i++)
            {
                if((itemsArray[i] != null) && (name == itemsArray[i].GetName()))
                {
                    return itemsArray[i];
                }
            }
            return null;
        }

        // TODO: Uncomment the following code:

        public void DisplayInventory(int x, int y)
        {
            Console.SetCursorPosition(x, ++y);
            Console.Write("Item Name");
            Console.SetCursorPosition(x + 17, y);
            Console.Write("Item Cost");

            for (int i = 0; i < maxSize; i++)
            {
                if (null != itemsArray[i])
                {
                    Console.SetCursorPosition(x, ++y);
                    Console.Write(itemsArray[i].GetName());
                    Console.SetCursorPosition(x + 17, y);
                    Console.Write(itemsArray[i].GetCost());
                }
            }

            y += 2;
            Console.SetCursorPosition(x, ++y);
            Console.Write("Gold on hand:");
            Console.SetCursorPosition(x+17, y);
            Console.Write(theGold);
        }
    }
}
