using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{
    [SerializeField] string[] array;
    [SerializeField] List<string> list;

    void Start()
    {
        // Length
        Debug.Log(array.Length);
        Debug.Log(list.Count);

        // Indexing
        Debug.Log(array[1]);
        Debug.Log(list[1]);

        // Arraies are fix Length
        // Lists are dinamic
        list.Add("dfsg");
        list.Remove("dfsg");
        list.RemoveAt(4);
        list.Insert(3, "2345fwesr");
        bool isContaining = list.Contains("dfgh");
        list.Sort(); // Sorba rendez
        list.Clear();
        

        List<Vector2> v2List = new List<Vector2>();


    } 
}