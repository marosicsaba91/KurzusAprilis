using UnityEngine;

public class ArrayPractice2 : MonoBehaviour
{
    void MyMethod()
    {
        int[] array0 = new int[5];
        int[] array1 = new int[] { 2, 5, 7 };
        int[] array2 = { 2, 5, 7 };

        int[] array3 = array2;
        array1[1] = 9;
        array3[1] = 4;

        Debug.Log(array1[1] + array2[1]);
        // ???

        Debug.Log(array2[1] + array3[1]);
        // ???

        float[] floatArray = new float[] { 2, 5, 7 };
        float[] newArray = Half(floatArray);
    }

    float[] Half(float[] original) 
    {
        float[] result = new float[original.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = original[i] / 2;
        }
        return result;
    }
}
