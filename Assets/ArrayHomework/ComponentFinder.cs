using System.Collections.Generic;
using UnityEngine;

public class ComponentFinder : MonoBehaviour
{
    [SerializeField] List<GameObject> objects;

    void OnValidate()
    {
        var allBoxCollider = FindObjectsOfType<BoxCollider>();
        foreach (BoxCollider c in allBoxCollider)
        {
            MeshRenderer m = c.GetComponent<MeshRenderer>();
            if (m != null)
                objects.Add(m.gameObject);
        }
    }











    void ComponentFindingFunctionPalette()
    {
        // --------------- A LEGELSO AMIT TALAL ---------------

        // Sajat GameObject Rigidbody-ja:
        Rigidbody a = GetComponent<Rigidbody>();

        // Sajat vagy gyerek GameObject BoxColliderje:
        BoxCollider b = GetComponentInChildren<BoxCollider>();

        // Sajat vagy szulo GameObject ClickExplosion komponense:
        ClickExplosion c = GetComponentInParent<ClickExplosion>();

        // Az osszes betoltott GameObject elso talalt Rigidbody-ja:
        Rigidbody d = FindObjectOfType<Rigidbody>();

        // --------------- AZ OSSZES ---------------

        // Sajat GameObject Rigidbody-jai:
        Rigidbody[] at = GetComponents<Rigidbody>();

        // Sajat vagy gyerek GameObject BoxColliderjai:
        BoxCollider[] bt = GetComponentsInChildren<BoxCollider>();

        // Sajat vagy szulo GameObject ClickExplosion komponensei:
        ClickExplosion[] ct = GetComponentsInParent<ClickExplosion>();

        // Az osszes betoltott GameObject osszes Rigidbody-ja:
        Rigidbody[] dt = FindObjectsOfType<Rigidbody>();
    }
}