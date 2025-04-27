using UnityEngine;

public class DeadLine : MonoBehaviour
{
    private GameObject respawnPoint;
    void Start()
    {
        respawnPoint = GameObject.Find("respawnPoint"); // 用名字找物件
        if (respawnPoint == null)
        {
            Debug.LogWarning("找不到名為 respawnPoint 的重生點喔！");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.position = respawnPoint.transform.position;
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
            }
        }
    }
}
