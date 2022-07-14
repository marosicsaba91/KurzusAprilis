using UnityEngine;

public class AvatarInput : MonoBehaviour
{
    [SerializeField] KeyCode rightKey;
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;

    [SerializeField] KeyCode shootKey;
    [SerializeField] KeyCode jumpKey;

    public Vector3 InputVector()
    {
        bool right = Input.GetKey(rightKey);
        bool left = Input.GetKey(leftKey);
        float xMovement = ToNumber(right, left);

        bool up = Input.GetKey(upKey);
        bool down = Input.GetKey(downKey);
        float zMovement = ToNumber(up, down);
        
        return new Vector3(xMovement, 0, zMovement);
    }

    public bool IsShooting()
    {
        return Input.GetKeyDown(shootKey);
    }
    public bool IsJumping()
    {
        return Input.GetKeyDown(jumpKey);
    }

    /*
    bool MyGetKey(KeyCode[] keys)
    {
        foreach (var key in keys)
        {
            if (Input.GetKey(key))
                return true;
        }
        return false;
    }
    */
    float ToNumber(bool positive, bool negative)
    {
        float positiveValue = positive ? 1 : 0;
        float negativeValue = negative ? -1 : 0;

        return positiveValue + negativeValue;
    }

}