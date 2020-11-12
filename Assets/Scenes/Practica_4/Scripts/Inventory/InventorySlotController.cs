using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace P4
{
    public class InventorySlotController : MonoBehaviour
    {
        public Item item;

        public void UpdateInfo()
        {
            Text displayText = transform.Find("Name").GetComponent<Text>();
            Image displayImage = transform.Find("Texture").GetComponent<Image>();
            
            if (item)
            {
               
                displayText.text = item.itemName;
                displayImage.sprite = item.icon;
            }
            else
            {
                displayText.text = "";
                displayImage.sprite = null;
                

            }

        }

        public void Use()
        {
            if (item != null)
            {
                item.Use();
               
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            UpdateInfo();

        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}