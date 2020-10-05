using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica_1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int i;
        int[] list;
        list = listOfMinsEach(new int[5]{8,1,2,2,3});

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
        //complejidad
        int[] auxList = new int[list.Length]; //3
        int count = 0; //1
        int i, j; //0

        for(i = 0; i < list.Length; i++)// 1; N+1; N
        {
            
            for(j = 0; j < list.Length; j++)//N; N^2 + N; N^2
            {
                if(list[j] < list[i]) //3*N^2
                    count++;//2 * N^2

            }

            auxList[i] = count; //2N
            count = 0;//N

        }
        

        return auxList;//1

        //complejidad
        //O(n) = 7N^2 + 7N + 7
    }
}
