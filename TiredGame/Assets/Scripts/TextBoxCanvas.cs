using UnityEngine;

public class TextBoxCanvas : MonoBehaviour
{
    private float timer = 1f;
    public GameObject textBoxGO;
    public GameObject textBoxTextGO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0f)
        {
            timer -= 0.1f * Time.deltaTime*10;
        }
        if(timer < 0.8f)
        {
            textBoxGO.SetActive(true);
        }
        if(timer <= 0f)
        {
            
            textBoxTextGO.SetActive(true);
        }
    }
}
