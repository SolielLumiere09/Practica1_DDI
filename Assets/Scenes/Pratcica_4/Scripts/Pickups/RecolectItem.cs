using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace P4
{
    public class RecolectItem : Interactable
    {
        public Item item;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (IsInsideZone & Input.GetKeyDown(KeyCode.E))
            {
                Inventory.inventory.addItem(item);
                Destroy(gameObject);
            }
            
        }
    }

}
