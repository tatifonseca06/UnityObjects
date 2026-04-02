using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;     // tu cubo
    public Vector3 offset;       // distancia respecto al cubo
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        
        transform.position = smoothedPosition;
    }
}