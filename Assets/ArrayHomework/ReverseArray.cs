using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseArray : MonoBehaviour
{
    [SerializeField] string[] inputArray;
    [SerializeField] string[] outputArray;

    void OnValidate()
    {
        if (inputArray == null)
            return;

        int l = inputArray.Length;
        outputArray = new string[l];

        for (int i = 0; i < l; i++)
        {
            outputArray[i] = inputArray[l - 1 - i];
        }
    }
}
