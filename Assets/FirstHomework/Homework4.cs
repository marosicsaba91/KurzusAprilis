using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework5 : MonoBehaviour
{
    [SerializeField] int primeCount; 

    [SerializeField] string result;

    void OnValidate()
    {
        int primeFound = 0;
        result = "";

        for (int i = 2; primeFound < 100; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= i/2; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primeFound++;

                if (primeCount == primeFound)
                    result += i;
                else
                    result += i + ", ";
            }
        }
    } 
}
