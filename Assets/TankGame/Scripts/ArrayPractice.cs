using UnityEngine;


public class ArrayPractice : MonoBehaviour
{
    [SerializeField] float[] input;
    [SerializeField] float mean;

    [SerializeField] string[] stringArray;
    [SerializeField] KeyCode[] keyCodes;
    // [SerializeField] Transform[] transforms;
    [SerializeField] Vector3 meanPosition;


    void OnValidate()
    {
        int length = input.Length;
        if (length != 0)
        {
            float first = input[0];
            float last = input[length - 1];
        }

        // Calculate Mean
        float summa = 0;
        for (int i = 0; i < length; i++)
        {
            summa += input[i];
        }
        mean = summa / length;
        if (float.IsNaN(mean))
            mean = 0;

        meanPosition = CalculateMeanPosition();



        // Creating Array
        int[] intArray = new int[5];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = i + 1;
        }
    }



    Vector3 CalculateMeanPosition()
    {
        Vector3 summaPosition = Vector3.zero;
        int nonNullElementCount = 0;

        Transform[] transforms = GetComponentsInChildren<Transform>();

        for (int i = 0; i < transforms.Length; i++)
        {
            if (transforms[i] != null && transforms[i] != transform)
            {
                summaPosition += transforms[i].position;
                nonNullElementCount++;
            }
        }

        return summaPosition / nonNullElementCount;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Transform[] transforms = GetComponentsInChildren<Transform>();
        for (int i = 0; i < transforms.Length; i++)
        {
            if (transforms[i] != null && transforms[i] != transform)
                Gizmos.DrawSphere(transforms[i].position, 0.15f);
        }
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(CalculateMeanPosition(), 0.15f);
    }
}