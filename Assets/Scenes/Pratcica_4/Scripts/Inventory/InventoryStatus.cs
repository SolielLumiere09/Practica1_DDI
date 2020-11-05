    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace P4
{
    public class InventoryStatus : MonoBehaviour
    {
        public GameObject inventoryPanel;
        
        // Start is called before the first frame update
        void Start()
        {
            inventoryPanel.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            
            if(Input.GetKeyDown(KeyCode.R))
            {
                inventoryPanel.SetActive(!inventoryPanel.activeSelf);

            }

        }
    }

}
