using UnityEngine;

public class SphereShooter : MonoBehaviour
{
    [SerializeField] GameObject spherePrefab;
    [SerializeField] Transform spherePointTr;

    float power = 50f;
    float destroyDelay = 50f;
    Rigidbody sphereRigidbody;
    GameObject activeSphere;

    void Start()
    {
        PrepareSphere();        
    }

    void Update()
    {
        ShootSphere();
        DestroyOutOfHight();
    }

    void PrepareSphere()
    {
        activeSphere = Instantiate(spherePrefab, spherePointTr);
        sphereRigidbody = activeSphere.GetComponent<Rigidbody>();
        ChangeSphereState(true);
    }

    void ShootSphere()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            ChangeSphereState(false);
            sphereRigidbody.AddForce(transform.forward * power, ForceMode.Impulse);
            PrepareSphere();
        }
    }

    void ChangeSphereState(bool state) 
    {
        sphereRigidbody.isKinematic = state;
        sphereRigidbody.GetComponent<Collider>().isTrigger = state;
    }

    void DestroyOutOfHight()
    {
        Destroy(activeSphere, destroyDelay);
    }
}
