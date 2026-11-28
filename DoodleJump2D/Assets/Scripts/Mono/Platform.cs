using UnityEngine;
using UnityEngine.Accessibility;

public class Platform : MonoBehaviour
{
    [Header("Variables:")]
    [Range(5f, 20f)]
    [SerializeField]
    private float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.relativeVelocity.y > 0)

        {
            if (col.gameObject.TryGetComponent<Rigidbody2D>(out Rigidbody2D rb))
            {
                rb.linearVelocityY = jumpForce;
            }
            
        
        }
    }
}
