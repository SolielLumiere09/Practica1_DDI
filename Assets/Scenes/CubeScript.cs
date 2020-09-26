using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int i;
        int[] list;
        list = listOfMinsEach(new int[6]{0,1,5,2,3, 4});

        for(i = 0; i < list.Length; i++)
        {
            Debug.Log(list[i] + " ");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    int[] listOfMinsEach(int [] list)
    {
        int[] auxList = new int[list.Length];
        int count = 0;
        int i, j;

        for(i = 0; i < list.Length; i++)
        {
            
            for(j = 0; j < list.Length; j++)
            {
                if(list[j] < list[i])
                    count++;

            }

            auxList[i] = count;
            count = 0;

        }
        

        return auxList;
    }
}
