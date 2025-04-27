using UnityEngine;
using UnityEngine.SceneManagement;
namespace Stage2
{
    public class Flag : MonoBehaviour
    {
        [SerializeField]
        private string sceneName;
        [SerializeField]
        private GameObject title;
        private int step=1;
        private bool isProcessing = false;
        void OnTriggerEnter2D(Collider2D collision)
        {
            act();
        }
        private void act()
        {
            isProcessing = true;
            if(step == 1)
            {
                GameObject stepPoint = GameObject.Find("step1");
                this.gameObject.transform.position = stepPoint.transform.position;
                step++;
            }
            else if(step == 2)
            {
                GameObject stepPoint = GameObject.Find("step2");
                this.gameObject.transform.position = stepPoint.transform.position;
                title.SetActive(true);
                step++;
            }
            else if(step == 3)
            {
                GameObject stepPoint = GameObject.Find("step3");
                this.gameObject.transform.position = stepPoint.transform.position;
                this.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                step++;
            }
            else if(step == 4)
            {
                SceneManager.LoadScene(sceneName);
            }
            isProcessing = false;
        }
    }
}