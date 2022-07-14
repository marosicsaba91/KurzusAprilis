using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] Transform objectToFollow;

    [SerializeField] Transform verticalRotationElement;
    [SerializeField] float verticalTurningSpeed = 10;

    void LateUpdate()
    {
        transform.position = objectToFollow.position;

        Vector3 rot = verticalRotationElement.localRotation.eulerAngles;

        if (Input.GetKey(KeyCode.W))
            rot.x += verticalTurningSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            rot.x -= verticalTurningSpeed * Time.deltaTime;

        verticalRotationElement.localRotation = Quaternion.Euler(rot);

    }
}
