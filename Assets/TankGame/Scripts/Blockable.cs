using System; 
using UnityEngine;

public class Blockable : MonoBehaviour
{
    [SerializeField] MonoBehaviour blockedScript;
    [SerializeField] Collider blockedCollider;

    float unBlockingTime;
    bool isBlocked;

    public void Block(float blockingTime)
    {
        SetEnable(false);
        unBlockingTime = Time.time + blockingTime;
        isBlocked = true;
    }

    void SetEnable(bool enable)
    {
        blockedScript.enabled = enable;
        blockedCollider.enabled = enable;
    }

    void Update()
    {
        if (isBlocked && Time.time >= unBlockingTime)
        {
            SetEnable(true);
            isBlocked = false;
        }
    }
}
