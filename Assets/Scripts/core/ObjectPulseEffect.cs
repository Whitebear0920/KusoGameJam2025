using UnityEngine;

public class ObjectPulseEffect : MonoBehaviour
{
    public float pulseSpeed = 2f;   // 放大縮小的速度
    public float minScale = 0.9f;   // 最小縮放倍數
    public float maxScale = 1.1f;   // 最大縮放倍數

    private Vector3 originalScale;  // 記錄初始大小

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void Update()
    {
        float scale = Mathf.Lerp(minScale, maxScale, (Mathf.Sin(Time.time * pulseSpeed) + 1f) / 2f);
        transform.localScale = originalScale * scale;
    }
}
