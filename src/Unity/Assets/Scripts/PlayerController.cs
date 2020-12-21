using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float SpeedPlayer;
    public float RotationSpeed;
    public Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            playerTransform.position += Vector3.forward * Time.deltaTime * SpeedPlayer;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerTransform.position += Vector3.back * Time.deltaTime * SpeedPlayer;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            playerTransform.Rotate(0f, -1f * RotationSpeed * Time.fixedDeltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerTransform.Rotate(0f, 1f * RotationSpeed * Time.fixedDeltaTime, 0f);
        }
    }
}
