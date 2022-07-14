using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework6 : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;

    [SerializeField] bool isPythagorian;

    void OnValidate()
    {
        isPythagorian = a * a + b * b == c * c;
    } 
}
