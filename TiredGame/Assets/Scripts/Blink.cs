using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Blink : MonoBehaviour
{
    private Graphic imageMat;
    public float alpha = 3f;
    public GameObject canvasGO;
    public GameObject camGO;
    public GameObject customerGO;
    public GameObject recipeGO;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NextCustomer.destroyGO = 0;
        anim = camGO.GetComponent<Animator>();
        imageMat = GetComponent<Image>();
        imageMat.color = new Color(0, 0, 0, alpha);
    }

    // Update is called once per frame
    void Update()
    {
        alpha -= 1f*Time.deltaTime;
        
        if (alpha < 0)
        {
            {
                if (CutsceneManager.skipCutscene == false)
                {
                    canvasGO.SetActive(true);
                    anim.Play("CamToRadio");
                    CutsceneManager.skipCutscene = true;
                    Destroy(this.gameObject);

                }
                else
                {
                    recipeGO.SetActive(true);
                    customerGO.SetActive(true);
                    Destroy(this.gameObject);
                }
            }
            
        }
    }
}
