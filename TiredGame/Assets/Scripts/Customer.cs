using UnityEngine;
using UnityEngine.SceneManagement;

public class Customer : MonoBehaviour
{
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("CustomerIntro");
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "OrderUp")
        {
            anim.Play("CustomerStandStill");
        }
      
    }
}
