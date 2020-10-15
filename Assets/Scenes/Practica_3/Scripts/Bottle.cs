using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : Interactable
{
    private MeshRenderer    m_meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        m_meshRenderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsInsideZone && Input.GetKeyDown(KeyCode.E)){

            m_meshRenderer.enabled = false;
        }
        
    }
}
