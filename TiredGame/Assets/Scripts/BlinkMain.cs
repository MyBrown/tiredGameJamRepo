using UnityEngine;

public class BlinkMain : MonoBehaviour
{
    public float alpha = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alpha -= 1f * Time.deltaTime;
        if(alpha < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
