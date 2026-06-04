using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public GameObject blackScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickMain()
    {
        blackScreen.SetActive(true);
        NextCustomer.destroyGO = 4;
        SceneManager.LoadScene("MainMenu");
    }
}
