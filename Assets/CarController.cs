using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Vertical");   // W/S หรือ ↑/↓
        float turn = Input.GetAxis("Horizontal"); // A/D หรือ ←/→

        // เดินหน้า-ถอยหลัง
        Vector3 movement = transform.forward * move * speed;
        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);

        // หมุนซ้ายขวา
        if (move != 0)
        {
            transform.Rotate(Vector3.up * turn * rotationSpeed * Time.fixedDeltaTime);
        }
    }
}
