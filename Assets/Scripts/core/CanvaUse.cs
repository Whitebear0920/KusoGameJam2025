using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvaUse : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
