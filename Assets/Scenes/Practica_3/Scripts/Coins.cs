using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : Interactable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsInsideZone)
        {
            GetComponent<MeshRenderer>().enabled = false;

        }
        GetComponent<Transform>().localRotation *= Quaternion.Euler(0,10,0);
    }
}
