using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float SpeedPlayer;
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Instancie mon Player");
    }

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
            
        }

    }

    void FixedUpdate()
    {

    }
}
