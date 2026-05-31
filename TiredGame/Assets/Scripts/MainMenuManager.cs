using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class MainMenuManager : MonoBehaviour
{
    public Button button;
    public int buttonChooser;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(ButtonStart);
        button.onClick.AddListener(ButtonCredits);
        button.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick()
    {
        button.onClick.Invoke();


    }

    public void ButtonCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void ButtonStart()
    {
        SceneManager.LoadScene("Chris' testing scene");
    }


}