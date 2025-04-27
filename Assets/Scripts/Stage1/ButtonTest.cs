using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    [SerializeField]
    private GameObject sheep;
    public void TestMessage()
    {
        sheep.SetActive(true);
        Debug.Log("ONCLICK");
    }
}
