using UnityEngine;
using UnityEngine.Events;

public class SphereShooter : MonoBehaviour
{
    [SerializeField] GameObject spherePrefab;
    [SerializeField] Transform spherePointTr;

    float power = 50f;
    Rigidbody sphereRigidbody;

    GameObject[] spherePool;
    int sphereAmount = 20;

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

    void PrepareSphereFromPool()
    {
        foreach (var sphere in spherePool)
        {
            if (!sphere.activeSelf)
            {
                sphere.SetActive(true);
                sphereRigidbody = sphere.GetComponent<Rigidbody>();
                ChangeSphereState(true);
            }
        }
    
    }

    void CreateSpherePool() 
    {
        for (int i = 0; i < sphereAmount; i++)
        {
            spherePool[i] = Instantiate(spherePrefab,spherePointTr);
            spherePool[i].SetActive(false);
        }    
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
}
