using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField]
    float movementSpeed = 50f;

    [SerializeField]
    float rotationSpeed = 150f;

    // Update is called once per frame
    void Update()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float deltaTime = Time.deltaTime;
        // z is forward
        transform.Translate(new Vector3(0, 0, verticalAxis) * movementSpeed * deltaTime);

        float horizontalAxis = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, horizontalAxis, 0) * rotationSpeed * deltaTime);
    }
}
