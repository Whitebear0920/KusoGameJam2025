using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            Color color = sr.color;
            color.a = 0f;
            sr.color = color;
        }
    }
}
