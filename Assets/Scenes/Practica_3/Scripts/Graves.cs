using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graves : Interactable
{
    
    private Transform       m_transform;
   
    public Vector3         m_MoveDirection;
    public Vector3         m_LastDirection;

    public float            m_offset;

    void Awake() {

        m_transform = GetComponent<Transform>();

    }
    void Start() {
        
    }

    void Update() {
        if(IsInsideZone && Input.GetKey(KeyCode.E) && Vector3.Distance(m_transform.localPosition, m_LastDirection) > m_offset){
            m_transform.localPosition += m_MoveDirection;
        

        }
    }


}
