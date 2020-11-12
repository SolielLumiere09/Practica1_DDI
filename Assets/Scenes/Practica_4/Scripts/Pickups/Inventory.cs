using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace P4
{
    public class Inventory : MonoBehaviour
    {
        public GameObject inventoryPanel;
        public int maxSizeOfElements;
        public List<Item> list = new List<Item>();
        public static Inventory inventory;
        
        public void UpdateSlots()
        {
            int index = 0;
            foreach (Transform child in inventoryPanel.transform)
            {
                
                InventorySlotController slot = child.GetComponent<InventorySlotController>();
                if (index < list.Count)
                {
                    slot.item = list[index];
                   
                }
                else
                {
                    slot.item = null;
                }
                
                slot.UpdateInfo();
                index++;
            }
            
        }

        public void addItem(Item item)
        {
            if (list.Count < maxSizeOfElements)
            {
                list.Add(item);

            }
            UpdateSlots();
        }

        public void removeItem(Item item)
        {
            list.Remove(item);
            UpdateSlots();
        }

        // Start is called before the first frame update
        void Start()
        {
            inventory = this;
            UpdateSlots();
        }
    }
}
