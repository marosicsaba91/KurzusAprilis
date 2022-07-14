using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework1 : MonoBehaviour
{
    [SerializeField] int number;

    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;

            if (fizz && buzz)
                Debug.Log("fizzbuzz");
            else if (fizz)
                Debug.Log("fizz");
            else if (buzz)
                Debug.Log("buzz");
            else
                Debug.Log(i);
        }

    }
}
