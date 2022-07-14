using UnityEngine;

public class ArrayPractice3 : MonoBehaviour
{
    [SerializeField] float[] inputArray;
    [SerializeField] float sum;

    void OnValidate()
    {
        // Foreach
        /*
        sum = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            sum += inputArray[i];
        }
        */

        sum = 0;
        foreach (float item in inputArray)
        {
            sum += item;
        }

        // Strings
        string st = "Bear"; // Medve
        char[] charArray = st.ToCharArray();
        charArray[2] = 'e';
        string newSt = new string(charArray);  // Sör
    }
}
