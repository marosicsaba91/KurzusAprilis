using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework8 : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int digitsSum;

    void OnValidate()
    {
        int n = number;
        digitsSum = 0;

        while (n>0) 
        {
            digitsSum += n % 10;
            n /= 10;
        }
    } 
}
