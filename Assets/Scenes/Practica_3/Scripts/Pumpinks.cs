using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpinks : Interactable
{
    private Rigidbody       m_RigidBody;
    // Start is called before the first frame update
    void Start()
    {
        m_RigidBody = GetComponent<Rigidbody>();
        m_RigidBody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsInsideZone && Input.GetKeyDown(KeyCode.E))
        {
            m_RigidBody.isKinematic = false;
            
        }
        if(!m_RigidBody.isKinematic && Input.GetKeyDown(KeyCode.R) && IsInsideZone){

    
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<CapsuleCollider>().enabled = false;
            GetComponent<MeshCollider>().enabled = false;
                
            
        }

        
        
    }
}
