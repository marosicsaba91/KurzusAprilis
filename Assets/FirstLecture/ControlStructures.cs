using UnityEngine;

public class ControlStructures : MonoBehaviour
{
    [SerializeField] int a;

    [SerializeField] string pairity;

    void Start()
    { 
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }

    void WhileLoop()
    {
        int i = 1;
        int count = 0;

        while (count < 10)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                Debug.Log(i);
                count++;
            }
            i++;
        }
    }

    void OnValidate()
    {
        if (a % 3 == 0)
            pairity = "Maradék: 0";
        else
        {
            if (a % 3 == 1)
                pairity = "Maradék: 1";
            else
                pairity = "Maradék: 2";
        }
        // UGYANAZ:

        pairity = $"Maradék: {a % 3}";
    }
}
