using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float SpeedPlayer;
    public float RotationSpeed;
    public Transform playerTransform;
    private Vector3 lastPosition;

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            lastPosition += Vector3.forward * Time.deltaTime * SpeedPlayer;
        }
        if (Input.GetKey(KeyCode.S))
        {
            lastPosition += Vector3.back * Time.deltaTime * SpeedPlayer;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            playerTransform.Rotate(0f, -1f * RotationSpeed * Time.fixedDeltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerTransform.Rotate(0f, 1f * RotationSpeed * Time.fixedDeltaTime, 0f);
        }

        playerTransform.position = lastPosition;
    }
}
