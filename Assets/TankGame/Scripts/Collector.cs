using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] int colletedValue; 
    [SerializeField] TMP_Text colletedValueText;

    void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.GetComponent<Collectable>();
        if (collectable != null)
        {
            colletedValue += collectable.value;
            collectable.Collect();
            UpdateText();
        }
    }

    void UpdateText() 
    {
        if (colletedValueText != null)
            colletedValueText.text = $"Score: {colletedValue}";
    }

    public void RestartCollector()
    {
        colletedValue = 0;
        UpdateText();
    }
}
