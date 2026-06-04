using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextCustomer : MonoBehaviour
{
    public GameObject fadeGO;
    public static float destroyGO = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TaskOnClick();
        if (SceneManager.GetActiveScene().name == "OrderUp")
        {
            if (destroyGO != 0)
            {
                destroyGO += 1f * Time.deltaTime;
            }

            if (destroyGO > 6)
            {
                SceneManager.LoadScene("Chris' testing scene");
            }
        }
    }

    public void TaskOnClick()
    {
        fadeGO.SetActive(true);
        destroyGO = 2f;
       
    }
}
