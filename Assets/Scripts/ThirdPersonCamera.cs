using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdPersonCamera : MonoBehaviour
{

    Vector3 offset;
    public Transform playerTransform;

    [SerializeField]
    Slider rotationSlider;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerTransform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
        CamOrbit();
    }

    private void CamOrbit()
    {
        float rotationSpeed = rotationSlider.value;
        float verticalInput = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        float horizontalInput = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        // Rotate the camera around the player
        transform.RotateAround(playerTransform.position, Vector3.up, horizontalInput);
        transform.RotateAround(playerTransform.position, transform.right, -verticalInput);

        // Update the offset to maintain the same distance from the player
        offset = transform.position - playerTransform.position;
        print(offset);

        // Keep the camera looking at the player
        transform.LookAt(playerTransform);
    }

}


