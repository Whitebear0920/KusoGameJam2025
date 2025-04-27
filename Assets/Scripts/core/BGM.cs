using UnityEngine;

public class BGM : MonoBehaviour
{
    private static BGM instance;

    private void Awake()
    {
        // 如果已經有一個存在，且不是自己
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // 刪掉自己
            return;
        }

        // 第一次建立
        instance = this;
        DontDestroyOnLoad(gameObject); // 切換場景時不刪除自己
    }
}
