using UnityEngine;
public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;

    public bool _canMove;
    public bool _hasKey;
    public string _keyValue;
    public GameObject _key;
    private Animator _animator;

    [SerializeField] float _speed;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _canMove = true;
    }
    void Update()
    {
        if (!_canMove)
        {
            rb.velocity = Vector2.zero;
            return;
        }
        Movement();
    }
    void Movement()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;
        if (direction.magnitude > 0)
        {
            _animator.SetBool("walk", true);
            rb.velocity = direction * _speed;
            if (direction.x > 0)
            {
                transform.localScale = new Vector2(1, 1);
            }
            else if (direction.x < 0)
            {
                transform.localScale = new Vector2(-1, 1);
            }
        }
        else
        {
            _animator.SetBool("walk", false);
            rb.velocity = Vector2.zero;
        }
    }
}