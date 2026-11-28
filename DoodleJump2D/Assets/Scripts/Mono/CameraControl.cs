using UnityEngine;
using UnityEngine.Rendering;

public class CameraControl : MonoBehaviour
{
    [Header("Components:")]
    [SerializeField]
    private Transform targetT;

    [Header("Variables:")]
    [Range(500f, 150f)]
    [SerializeField]
    private float speed = 100f;

    void Update()
    {
        if (targetT == null) return;

        if (targetT.position.y > transform.position.y)
        {
            var newPos = new Vector3(transform.position.x, targetT.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, newPos, speed * Time.deltaTime);
        }
    }
}
