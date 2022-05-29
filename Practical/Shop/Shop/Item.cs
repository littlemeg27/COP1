//=============================================================================
// Program's Item class
//=============================================================================

namespace Shop
{
        class Shop
        { 
        // TODO: Write a class called Item that contains 2 data members:
        //       A string called name and an int called cost.
        //       This class should have a default constructor that sets name to ""
        //       and cost to 0.
        //       It should also have an overloaded constructor that accepts 2
        //       parameters - a string and an int.
        //
        //       Write getters/accessors for each data member. They should be called
        //       GetName and GetCost.
        //
        //       Write setters/mutators for each data member. They should be called
        //       SetName and SetCost.

            private string itemName;
            private int itemCost;

            public Shop()
            {
                itemName = "";
                itemCost = 0;
            }

            public Shop(string name, int cost)
            {
                itemName = name;
                itemCost = cost;
            }

            public string GetName() // Get for Name
            {
                return itemName;
            }

            public int GetCost() // Get for Cost
            {
                return itemCost;
            }

            public void SetName(string name) // Set for Item
            {
                itemName = name;
            }

            public void SetCost(int cost) // Set for Cost
            {
                itemCost = cost;
            }
        }
}
