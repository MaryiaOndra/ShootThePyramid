using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float power;
    Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rigidbody.isKinematic = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.isKinematic = false;
            rigidbody.AddForce(transform.forward * power, ForceMode.Impulse);
        }
    }
}
