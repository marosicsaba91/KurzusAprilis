using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMerger : MonoBehaviour
{
    [SerializeField] int[] a;
    [SerializeField] int[] b;

    [SerializeField] int[] merged;

    void OnValidate()
    {
        merged = new int[a.Length + b.Length];

        for (int i = 0; i < a.Length; i++)
            merged[i] = a[i];

        for (int i = 0; i < b.Length; i++)
            merged[a.Length + i] = b[i];
    }
}
