using System;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    [SerializeField] float acceleration = 1;
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] Space movementSpace = Space.World;

    [SerializeField] GameObject projectilePrototype;
    [SerializeField] Transform projectileStartPosition;

    [SerializeField] KeyCode[] rightKeys;
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;

    Damagable damagabe;

    float speed = 0;

    void Start()
    {
        damagabe = GetComponent<Damagable>();

    }

    void Update()
    {
        if (damagabe.health > 0)
        {
            Move();
            TryShoot();
        }
    }

    void TryShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(projectilePrototype);
            go.SetActive(true);
            Projectile p = go.GetComponent<Projectile>();

            Vector3 forward = transform.forward;
            go.transform.position = projectileStartPosition.position;
            p.Shoot(forward);
        }
    }

    bool MyGetKey(KeyCode[] keys) 
    {
        foreach (var key in keys)
        {
            if (Input.GetKey(key))
                return true;
        }
        return false;
    }

    void Move()
    {
        bool right = MyGetKey(rightKeys);
        bool left = Input.GetKey(leftKey);
        float xMovement = ToNumber(right, left);

        bool up = Input.GetKey(upKey);
        bool down = Input.GetKey(downKey);
        float zMovement = ToNumber(up, down);

        // SPEED
        if (right | left| up | down)
        {
            speed += acceleration * Time.deltaTime;
            speed = Mathf.Min(speed, maxSpeed);
        }
        else
        {
            speed = 0;
        }

        // MOVEMENT
        Vector3 movement = new Vector3(xMovement, 0, zMovement);

        if(movementSpace == Space.Self)
            movement = transform.TransformVector(movement);

        movement.y = 0;
        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;

        transform.position += movement;

        if(movement.magnitude != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            Quaternion currentRoatation = transform.rotation;

            transform.rotation =
                Quaternion.RotateTowards(
                    currentRoatation, 
                    targetRotation, 
                    angularSpeed * Time.deltaTime);
        }
    }

    float ToNumber(bool positive, bool negative)
    {
        float positiveValue = positive ? 1 : 0;
        float negativeValue = negative ? -1 : 0;

        return positiveValue + negativeValue;
    }

    public void RestartAvatar()
    {
        transform.position = Vector3.zero;
    }

}
