using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour
{
    void Start()
    {
        
    }

    float Ceil(float input)
    {
        if (input % 1 == 0)
            return input;
         
        float whole = (int)input;
        return whole + 1;
    }

    float Clamp(float value, float min, float max)
    {
        if (value < min)
            return min;
        if (value > max)
            return max;        
        return value;
    }

    float Lerp(float a, float b, float t)
    {
        if (t <= 0)
            return a;

        if (t >= 1)
            return b;

        float dif = b - a;
        return a + (t * dif);
    }
}
