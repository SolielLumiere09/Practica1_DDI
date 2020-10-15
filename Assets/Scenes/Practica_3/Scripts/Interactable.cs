using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    //temp
  
    ////
    protected bool IsInsideZone = false;
    // Start is called before the first frame update

    void Awake() {
       
       
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(IsInsideZone && Input.GetKey(KeyCode.E))
        {
            Debug.Log("interacting");
            
        }
        
    }
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            IsInsideZone = true;


        }

    }
    void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player"))
        {
            IsInsideZone = false;

        }

    }

}
