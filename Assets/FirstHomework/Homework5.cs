using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework4 : MonoBehaviour
{
    [SerializeField] int num; 

    [SerializeField] string result;

    void OnValidate()
    {
        result = "";
        for (int i = 1; i < num; i++)
        {
            result += i + ", ";
        }

        result += num;
    } 
}
