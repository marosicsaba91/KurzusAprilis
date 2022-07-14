using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class AvatarShooting : MonoBehaviour
{
    [SerializeField] GameObject[] projectilePrototypes;
    [SerializeField] bool isRandomSequence;
    [SerializeField] Transform projectileStartPosition;

    [SerializeField] Damagable damagabe;
    [SerializeField] AvatarInput input;

    int bulletCount = 0;

    void OnValidate()
    {
        if (damagabe == null)
            damagabe = GetComponentInChildren<Damagable>();
        if (input == null)
            input = GetComponentInChildren<AvatarInput>();
    }

    void Update()
    {
        if (damagabe.health > 0)
        { 
            TryShoot();
        }
    }

    void TryShoot()
    {
        if (input.IsShooting())
        {
            int bulletIndex = isRandomSequence ?
                Random.Range(0, projectilePrototypes.Length) :
                bulletCount % projectilePrototypes.Length;

            GameObject proto = projectilePrototypes[bulletIndex];
            GameObject go = Instantiate(proto);

            go.SetActive(true);
            Projectile p = go.GetComponent<Projectile>();

            Vector3 forward = transform.forward;
            go.transform.position = projectileStartPosition.position;
            bulletCount++;
            p.Shoot(forward);
        }
    }

}
