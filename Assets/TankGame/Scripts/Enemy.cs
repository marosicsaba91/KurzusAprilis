using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform[] targets; 

    [SerializeField] AnimationCurve speedOverDistance;

    void Update()
    {
        if (targets == null)         
        {
            return;
        }

        Vector3 targetPos = ClosestTarget();
        Vector3 enemyPos = transform.position;

        Vector3 movement = targetPos - enemyPos;

        float distance = movement.magnitude;

        float speed = speedOverDistance.Evaluate(distance);

        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;

        transform.position += movement;

        if(movement.magnitude != 0)
            transform.rotation = Quaternion.LookRotation(movement);
    }

    Vector3 ClosestTarget()
    {
        Vector3 selfPos = transform.position;
        float min = float.MaxValue;
        Vector3 closest = Vector3.zero;

        for (int i = 0; i < targets.Length; i++)
        {
            Transform target = targets[i];
            Vector3 targetPos = target.position;
            float distance = Vector3.Distance(targetPos, selfPos);
            if (distance < min)
            {
                min = distance;
                closest = targetPos;
            }
        }
        return closest;
    }
}
