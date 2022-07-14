using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework3 : MonoBehaviour
{
    [SerializeField] string text1;
    [SerializeField] string text2;
    [SerializeField] string text3;

    [SerializeField] string result;

    void OnValidate()
    {
        result = text1 + ", " + text2 + ", " + text3;
        result = $"{text1}, {text2}, {text3}";
    } 
}
