using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private Text _score;
    public static int score;
    
    public float movementSpeedMobile = 0.0065f;
    private float movementSpeedPC = 10f;
    float movement = 0f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }

    private void Update()
    {
        #if UNITY_EDITOR || UNITY_STANDALONE
        movement = Input.GetAxis("Horizontal") * movementSpeedPC;
        #endif
        #if UNITY_IOS || UNITY_ANDROID
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            
            transform.Translate(touchDeltaPosition.x * movementSpeedMobile, 0, 0);
        }
        #endif
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
        _score.text = $"{score}";
    }
}
