using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{

    public float xLimit = 10f;
    public float yLimit = 10f;

    public Transform map;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
    void Update()
    {
        //transform.LookAt(map); if we need to lock camera on map?

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 newPosition = transform.position;
        newPosition.x += horizontalInput;
        newPosition.z += verticalInput;

        newPosition.x = Mathf.Clamp(newPosition.x , -xLimit , xLimit);
        newPosition.z = Mathf.Clamp(newPosition.z , -yLimit , yLimit);

        transform.position = newPosition;

    }
}
