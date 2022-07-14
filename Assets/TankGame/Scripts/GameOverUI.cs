using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public void ResetEverything()
    {
        foreach (var item in FindObjectsOfType<AvatarMovement>())
            item.RestartAvatar();

        foreach (var item in FindObjectsOfType<Damagable>())
            item.RestartDamagable();

        foreach (var item in FindObjectsOfType<Collector>())
            item.RestartCollector();
    }
}
