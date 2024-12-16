using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform capsule; 
    public Vector3 offset = new Vector3(0, 1.5f, 0); 

    public float mouseSensitivity = 100.0f; 
    private float pitch = 0.0f; 

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        capsule.Rotate(0, mouseX, 0);

        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        transform.localEulerAngles = new Vector3(pitch, 0, 0);

        transform.position = capsule.position + offset;
    }
}
