using UnityEngine;

public class MethodsPractice : MonoBehaviour
{
    [SerializeField] float a; 
    [SerializeField] float b;

    [Space]
    [SerializeField] float max;
    [SerializeField] float min;
    [SerializeField] float absoluteValue;
    [SerializeField] float sign;
    [SerializeField] float power;

    void OnValidate()
    {
        max = Maximum(a, b);
        min = Mathf.Min(a, b);
        absoluteValue = AbsoluteValue(a);
        sign = Mathf.Sign(a);
        power = Power(a,5);
    }

    float Maximum(float a, float b) 
    {
        return a > b ? a : b;
    }

    float AbsoluteValue(float a)
    {
        return a >= 0 ? a : -a;
    }
    float Power(float base_, int exponent)
    {
        float result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= base_;
        }

        return result;
    }
}
