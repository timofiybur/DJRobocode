using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    [Header("Components:")]
    [SerializeField]
    private Rigidbody2D rb;

    [Header("Variables:")]
    [SerializeField]
    [Range(5f, 20f)]
    private float speed = 10f;

    private float directionX = 0f;
    private float screenWidth;

    private void Start()
    {
        screenWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    private void OnMove(InputValue input)
    {
        directionX = input.Get<Vector2>().x;
    }

    private void FixedUpdate()
    {
       rb.linearVelocityX = directionX * speed;
        if (transform.position.x > screenWidth)
        {
            transform.position = new Vector2(-screenWidth, transform.position.y);
        }
        else if (transform.position.x < -screenWidth)
        {
            transform.position = new Vector2(screenWidth, transform.position.y);
        }
    }
}
