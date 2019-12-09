using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueva : MonoBehaviour
{
    float[] array;
    bool test = false;
    // Start is called before the first frame update
    void Start()
    {
        array = new float[10];
        for(int i = 0; i < array.Length; i++)
        {
            array[0] = i * 10;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (array.Length > 5) test = true;
    }
	
	string Mensaje(string nombre)
	{
		return "Hola " + nombre;
	}
}
