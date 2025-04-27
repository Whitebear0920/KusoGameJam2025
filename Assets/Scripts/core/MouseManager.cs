using UnityEngine;

public class MouseManager : MonoBehaviour
{
    void Start()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
#endif
    }
}
