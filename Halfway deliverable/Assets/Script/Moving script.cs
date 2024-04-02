using UnityEngine;

public class MovingScript : MonoBehaviour
{
    public float speed = 5.0f;
    public float horizontalInput;
    public float forwardInput;


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.left * Time.deltaTime * speed * forwardInput);
    }
}

