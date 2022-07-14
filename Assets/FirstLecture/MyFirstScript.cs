using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [Header("Calculator")]
    [SerializeField] float input1;
    [SerializeField] float input2;
    [Space]
    [SerializeField] float summa;
    [SerializeField] float különbség;
    [SerializeField] float mod;

    [Header("Mean")]
    [SerializeField] int a = 1;
    [SerializeField] int b = 1;
    [SerializeField] int c = 1;
    [Space]
    [SerializeField] float mean;

    [Header("Circle")]
    [SerializeField] float radius;
    [Space]
    [SerializeField] float circumrerance;
    [SerializeField] float area;

    void Start()
    {
        float temp = input2;
        input2 = input1;
        input1 = temp;
    }

    void OnValidate()
    {
        summa = input1 + input2;
        különbség = input1 - input2;
        mod = input1 % input2;

        mean = (a + b + c) / 3f;

        circumrerance = 2 * radius * Mathf.PI;
        area = radius * radius * Mathf.PI;
    }
}
