using UnityEngine;
using UnityEngine.SceneManagement;

public class NextCustomer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TaskOnClick();
    }

    public void TaskOnClick()
    {
        SceneManager.LoadScene("Chris' testing scene");
    }
}
