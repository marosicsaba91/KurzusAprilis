using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallestCommonMultiplier : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    [Space]
    [SerializeField] int result;

    void OnValidate()
    {
        result = SmallestCommon(num1, num2);
    }

    int SmallestCommon(int a, int b)
    {
        if (a == 0 || b == 0)
            return -1;

        int smallest = Mathf.Min(a, b);
        int largest = Mathf.Max(a, b);


        for ( int i = smallest; true; i += smallest) 
        {
            if (i % largest == 0)
                return i;
        }
    }
}
