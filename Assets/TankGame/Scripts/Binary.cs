using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binary : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] string binary;

    void Update()
    {
        binary = "";
        int n = num;

        int pow = 1;
        while (pow < n)
        {
            pow *= 2; 
        }
        pow /= 2;

        while (pow > 0) 
        {
            if (n > pow)
            {
                binary += "1";
                n -= pow;
            }
            else
                binary += "0";

            pow = pow / 2;
        }
    }
}
