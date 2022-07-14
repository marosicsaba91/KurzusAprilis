using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework2 : MonoBehaviour
{
    [SerializeField] string text;

    [SerializeField] int textLength;

    void OnValidate()
    {
        textLength = text.Length;
    } 
}
