using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class problema : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] alumnos = new string[5]{"Abdiel", "Bael", "Carlos", "David", "Ernesto"};
        string alumno_target = "Abdiel";

        if(showDDIalumno(alumnos, alumno_target))
            Debug.Log("Alumno " + alumno_target + " Encontrado");
        else
            Debug.Log("Alumno " + alumno_target + " No Encontrado");
        
        showDDIalumno(alumnos, "Abdiel");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    bool showDDIalumno(string [] alumnos, string alumno_target)
    {
        int left = 0, right = alumnos.Length - 1; //4
        int half;

        while(left <= right)//2log(n)
        {
            half = (left + right) / 2;//3log(n)

            if(alumno_target.Equals(alumnos[half]))//2log(n)
                return true;
            
            if(alumno_target.CompareTo(alumnos[half]) < 0)//2log(n)
                right = half - 1;//2log(n)
            else
                left = half + 1;//2log(n)

        }

        return false;


        //complejidad
        //O(log(n)) = 17log(n) + 5

    }
}
