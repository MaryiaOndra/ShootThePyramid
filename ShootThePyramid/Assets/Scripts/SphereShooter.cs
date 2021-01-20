using UnityEngine;
using UnityEngine.Events;

public class SphereShooter : MonoBehaviour
{
    [SerializeField] GameObject spherePrefab;
    [SerializeField] Transform spherePointTr;

    float power = 50f;
    Rigidbody sphereRigidbody;

    void Start()
    {
        PrepareSphere();        
    }

    void Update()
    {
        ShootSphere();
    }
    void PrepareSphere()
    {
        sphereRigidbody = Instantiate(spherePrefab, spherePointTr).GetComponent<Rigidbody>();
        sphereRigidbody.GetComponent<Collider>().isTrigger = true;
        sphereRigidbody.isKinematic = true;
    }

    void ShootSphere()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            sphereRigidbody.isKinematic = false;
            sphereRigidbody.GetComponent<Collider>().isTrigger = false;
            sphereRigidbody.AddForce(transform.forward * power, ForceMode.Impulse);
            PrepareSphere();
        }
    }
}
