using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System.Linq;

public class Textbox : MonoBehaviour
{
    private string textbox = "";
    public string textToWrite;
    private Text text;
    public int page = 0;
    public float timer = 20f;
    public int charInt;
    public GameObject textBoxGO;
    public GameObject customerGO;
    private Animator anim;
    private float recipeTimer;
    public GameObject recipeGO;
    private Animator camAnim;
    public GameObject camGO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<Text>();
       anim = textBoxGO.GetComponent<Animator>();
        camAnim = camGO.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        switch (page)
        {
            case 0:
                //charInt = 0;
             
              
                textToWrite = "Howdy, folks! Welcome to another listen sesh on Cappu radio. I'm your host, Lisa Mocha, and before we get into those morning tunes for you early birds, I'm gonna read off some announcements for the month of June!";
                break;
            case 1:
                //charInt = 0;
               
                textToWrite = "First and foremost, it's pride month! To all the lovely folks out there, get out there and celebrate your pride if you haven't already. Be on the lookout for your local parades as they happen throughout the month.";
                break;
            case 2:
                //charInt = 0;
               
                textToWrite = "In other news, new movies are popping up like crazy this summer. I think there's a new slasher film coming out. A little early in my opinion, but it's whatever.\r\n";
                break;
            case 3:
                //charInt = 0;
                
                textToWrite = "Anyhoo, I'm Lisa Mocha, and now we shall tune into 86.5 radio!";
                break;
            case 4:
                //charInt = 0;
                anim.Play("CloseTextbox");
                camAnim.Play("RadioToReg");
                customerGO.SetActive(true);
                textToWrite = "";
                recipeTimer = 6f;
                break;
        }
        if (timer > 0)
        {
            timer -= (1f * (Time.deltaTime*20));
        }
        if(timer <= 0)
        {
            if (textbox.Length < textToWrite.Length)
            {
                timer = 1f;
                textbox += textToWrite[charInt];
                text.text = textbox;
                charInt += 1;
            }
        }
       if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            charInt = 0;
            textbox = "";
            text.text = textbox;
            page += 1;
            
        }
        if (recipeTimer > 0)
        {
            recipeTimer -= (1f * Time.deltaTime);
        }
        if(recipeTimer <= 0 && page >= 4)
        {
            recipeGO.SetActive(true);
        }
    }
}
