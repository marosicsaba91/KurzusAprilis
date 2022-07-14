using UnityEngine;

public class AvatarMovement : MonoBehaviour
{
    [SerializeField] float acceleration = 1;
    [SerializeField] float maxSpeed = 5;
    [SerializeField] float angularSpeed = 360;
    [SerializeField] Space movementSpace = Space.World;

    [SerializeField] Damagable damagabe;
    [SerializeField] AvatarInput input;

    float speed = 0;

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
            Move();
        }
    }

    void Move()
    {

        Vector3 inputVector = input.InputVector();

        // SPEED
        if (inputVector != Vector3.zero)
        {
            speed += acceleration * Time.deltaTime;
            speed = Mathf.Min(speed, maxSpeed);
        }
        else
        {
            speed = 0;
        }

        // MOVEMENT
        Vector3 movement = inputVector;

        if (movementSpace == Space.Self)
            movement = transform.TransformVector(movement);

        movement.y = 0;
        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;

        transform.position += movement;

        if (movement.magnitude != 0)
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
    public void RestartAvatar()
    {
        transform.position = Vector3.zero;
    }

}
