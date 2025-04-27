using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("跟隨設定")]
    public Transform target;     // 玩家
    public Vector3 offset = new Vector3(0, 0, -10); // 與玩家的距離
    public float followSpeed = 5f; // 跟隨速度

    private void LateUpdate()
    {
        if (target == null) return;

        // 平滑跟隨
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}
