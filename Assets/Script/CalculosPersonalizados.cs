using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{
    public float num1;
    public float num2;

    // Start is called before the first frame update
    void Start()
    {
        float[] Resultado = {num1 + num2, num1 - num2, num1 * num2, num1 / num2};

        Debug.Log("La suma da "+Resultado[0]+", la resta da "+ Resultado[1]+", la multiplicacion da "+Resultado[2]+
        " y la division da "+Resultado[3]+".");  
    }
}