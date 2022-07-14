using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] int damage = 1;

    void OnTriggerEnter(Collider other)
    {
        Damagable damageble = other.GetComponent<Damagable>();
        if (damageble != null)
        {
            damageble.DoDamage(damage);
        }
    }
}
