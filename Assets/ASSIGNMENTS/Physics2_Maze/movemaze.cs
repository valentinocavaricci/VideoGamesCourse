using UnityEngine;

public class MazeTilt : MonoBehaviour
{
    public float tiltSpeed = 120f;
    public float maxTilt = 20f;

    private float tiltX;
    private float tiltZ;

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        tiltZ += inputX * tiltSpeed * Time.deltaTime;
        tiltX -= inputZ * tiltSpeed * Time.deltaTime;

        tiltX = Mathf.Clamp(tiltX, -maxTilt, maxTilt);
        tiltZ = Mathf.Clamp(tiltZ, -maxTilt, maxTilt);

        Quaternion target = Quaternion.Euler(tiltX, 0f, tiltZ);

        transform.localRotation =
            Quaternion.Slerp(transform.localRotation, target, 6f * Time.deltaTime);

    }
}