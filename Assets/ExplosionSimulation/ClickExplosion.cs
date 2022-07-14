
using UnityEngine;

public class ClickExplosion : MonoBehaviour
{
    [SerializeField] LayerMask mask;

    [SerializeField] float explosionForce;
    [SerializeField] float explosionRadius;
    [SerializeField] float upwardModifier;
    [SerializeField] Camera camera;
    [SerializeField] ParticleSystem particleSystem;

    void OnValidate()
    {
        if (particleSystem == null)
            particleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo, float.MaxValue, mask)) 
            {
                Rigidbody[] allRgbds = FindObjectsOfType<Rigidbody>();

                foreach (var rgbd in allRgbds)
                {
                    transform.position = hitInfo.point;
                    particleSystem.Play();
                    rgbd.AddExplosionForce(
                        explosionForce,
                        hitInfo.point,
                        explosionRadius,
                        upwardModifier,
                        ForceMode.Impulse);
                }


                Debug.Log(hitInfo.point);             
            }    
        }            
    }
}
