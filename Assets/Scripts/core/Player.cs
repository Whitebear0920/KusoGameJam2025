using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動設定")]
    public float moveSpeed = 5f;
    public float sprintMultiplier = 1.5f;
    public float jumpForce = 8f;

    [Header("地板檢測 (改成BoxCast)")]
    public Vector2 groundCheckSize = new Vector2(0.5f, 0.1f); // 設定檢測框大小
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private bool isGrounded;
    private GameObject res;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        res = GameObject.Find("respawnPoint");
        this.gameObject.transform.position = res.transform.position;
    }

    private void Update()
    {
        // 移動輸入
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = 0f;

        // 衝刺
        float currentSpeed = moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed *= sprintMultiplier;
        }
        moveInput *= currentSpeed;

        // 地板檢測 (BoxCast)
        isGrounded = Physics2D.BoxCast(transform.position, groundCheckSize, 0f, Vector2.down, 0.1f, groundLayer);

        // 跳躍
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.gameObject.transform.position = res.transform.position;
            rb.linearVelocity = Vector2.zero;
        }

        /*// 朝向翻轉
        if (moveInput.x != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(moveInput.x), 1, 1);
        }*/
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInput.x, rb.linearVelocity.y);
    }

    private void OnDrawGizmos()
    {
        // 畫出BoxCast的區域，方便主人調整大小
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position + Vector3.down * 0.05f, groundCheckSize);
    }
}
