using UnityEngine;

public class FaceChange : MonoBehaviour
{
    [SerializeField]
    private GameObject sad;
    [SerializeField]
    private GameObject smile;
    [SerializeField]
    private GameObject step;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            smile.SetActive(false);
            sad.SetActive(true);
            step.SetActive(true);
        }
    }
}
