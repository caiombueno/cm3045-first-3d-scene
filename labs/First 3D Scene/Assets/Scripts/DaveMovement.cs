using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaveMovement : MonoBehaviour
{

    [SerializeField]
    float movementSpeed;

    [SerializeField]
    float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        float deltaTime = Time.deltaTime;
        // z is forward
        transform.Translate(new Vector3(0, 0, verticalInput) * movementSpeed * deltaTime);

        transform.Rotate(new Vector3(0, horizontalInput, 0) * rotationSpeed * deltaTime);
    }
}
