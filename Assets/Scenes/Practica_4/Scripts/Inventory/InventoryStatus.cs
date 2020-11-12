    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using UnityStandardAssets.CrossPlatformInput;

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
            
            if(Input.GetKeyDown(KeyCode.R) || (CrossPlatformInputManager.GetButtonDown("Inventory")))
            {
                inventoryPanel.SetActive(!inventoryPanel.activeSelf);

            }

        }
    }

}
