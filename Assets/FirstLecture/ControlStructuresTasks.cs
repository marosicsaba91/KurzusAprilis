using UnityEngine;

public class ControlStructuresTasks : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] int count;

    void OnValidate()
    {
        count = 0;
        for (int i = 1; i<num; i++)
        {
            if(num % i == 0)
                count ++;

        }
    }
}
