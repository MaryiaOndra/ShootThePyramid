using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardRotator : MonoBehaviour
{
    public float sensitivity = 10f;
    public float maxYAngle = 80f;
    private Vector2 currentRotation;

    [SerializeField] private GameObject spherePrefab;

    private void Start()
    {
        float offset = 0.01f;
        GameObject.Instantiate(spherePrefab, transform.forward * offset, transform.rotation, transform);
    }

    void Update()
    {
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
        Camera.main.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);
        if (Input.GetMouseButtonDown(0))
            Cursor.lockState = CursorLockMode.Locked;

        transform.eulerAngles = new Vector3(currentRotation.y, currentRotation.x, 0.0f);


    }
}
