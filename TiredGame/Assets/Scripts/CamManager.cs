using UnityEngine;

public class CamManager : MonoBehaviour
{
    private int camSwitch;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("camToRadio");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
