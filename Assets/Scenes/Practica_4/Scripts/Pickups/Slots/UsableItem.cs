using System.Collections;
using System.Collections.Generic;
using P4;
using UnityEngine;

namespace p4
{
    
    [CreateAssetMenu (fileName = "New Item", menuName = "Item/Consumable")]
    public class UsableItem : P4.Item
    {
        public override void Use()
        {

            if (name.Equals("Emerald"))
            {
                Debug.Log("using item " + name);
                
            }

            if (name.Equals("Cubie"))
            {
                Debug.Log("using item " + name);
            }

            if (name.Equals("4SideDiamond"))
            {
                Debug.Log("using item " + name);
                
            }

            if (name.Equals("SphereGem"))
            {
                Debug.Log("using item " + name);
                
            }

            if (name.Equals("Diamond"))
            {
                Debug.Log("using item " + name);
            }

            Inventory.inventory.removeItem(this);
        }
    }
}
