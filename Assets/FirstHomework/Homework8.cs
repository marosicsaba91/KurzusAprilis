using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework7 : MonoBehaviour
{
    [SerializeField] int a; // 12
    [SerializeField] int b; // 5

    void Start()
    {
        a += b;  // a = 17
        b = a - b; // b = 12
        a -= b; // a = 5
    } 
}
