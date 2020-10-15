using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHands : Interactable
{

    private Transform tf;
    private Quaternion rotationSpeed;


    void Awake() {
        tf = GetComponent<Transform>();    
        rotationSpeed = Quaternion.Euler(0,10,0);
    }

    // Start is called before the first frame update   
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsInsideZone && Input.GetKey(KeyCode.E)){

            tf.localRotation = tf.localRotation * rotationSpeed;
        }
        
    }
}
