using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creepy_train : Interactable
{
    private Transform   m_Transform;
    private Quaternion  m_rotationSpeed;
    private Vector3 [] m_directions;
    public int index;

    public float speed;

    private bool start = false;
    void Awake() {

        m_Transform = GetComponent<Transform>();
        m_rotationSpeed = Quaternion.Euler(0,10,0);
        
        m_directions = new Vector3[4]{new Vector3(-0.64f, -2.139f, -0.87f), new Vector3(-0.64f,-2.139f,24.48f), new Vector3(18.58f,-2.139f,24.48f), new Vector3(18.58f,-2.139f,-0.87f)};
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsInsideZone && Input.GetKeyDown(KeyCode.E))
        {
            start = true;
            index = (int)(Random.Range(0f, 3f));
            if(index < 0)
                index = 0;
            
        }

        if(start)m_Transform.localPosition = Vector3.MoveTowards(m_Transform.localPosition, m_directions[index], speed * Time.deltaTime);
        m_Transform.localRotation = m_Transform.localRotation * m_rotationSpeed;

        if(Vector3.MoveTowards(m_Transform.localPosition, m_directions[index], speed * Time.deltaTime) == m_Transform.localPosition)
            index = (int)(Random.Range(0f, 4f));

        
    }

}
