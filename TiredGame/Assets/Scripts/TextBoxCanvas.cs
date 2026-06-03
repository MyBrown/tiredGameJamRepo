using UnityEngine;

public class TextBoxCanvas : MonoBehaviour
{
    private float timer = 0f;
    public GameObject textBoxGO;
    public GameObject textBoxTextGO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       textBoxGO.SetActive(true);
        timer = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0f)
        {
            timer -= 1f * Time.deltaTime;
        }
       
        if(timer < 0f)
        {
            
            textBoxTextGO.SetActive(true);
        }
    }
}
