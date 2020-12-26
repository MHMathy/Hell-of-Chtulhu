using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundDistance = 0.4f;
    public float speed = 12f;
    public float gravity = -9.81f;
    private Vector3 velocity;
    private bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(5f * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
