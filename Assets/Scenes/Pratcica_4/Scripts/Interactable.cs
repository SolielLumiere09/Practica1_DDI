using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace P4
{
    public class Interactable : MonoBehaviour
    {
        protected bool IsInsideZone;


        protected virtual void Interact()
        {
            Debug.Log("Interactuando");
            
            
        }

        // Start is called before the first frame update
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                IsInsideZone = true;
                
              
            }


        }

        protected virtual void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                IsInsideZone = false;
                

            }

        }


    }
}
