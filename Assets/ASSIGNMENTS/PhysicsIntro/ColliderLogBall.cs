using UnityEngine;

public class ColliderLogBall : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            var force = new Vector3(0, 10, 0);
            rb.AddForce(force);
            }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I have collided with " + collision.gameObject.name);
    }
}
