using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecipeManager : MonoBehaviour
{
    private string[] toppings = {"sugar","cinnamon","milk"};
    private string[] liquids = { "tea","coffee","milk"};
    public GameObject toppingGO;
    public GameObject liquidGO;
    public GameObject receiptGO;
    private string liquid;
    private string topping;
    public static Text liquidUI;
    public static Text toppingUI;
    private int lineSwitch = 0;
    private bool play = false;
    public static float recipeTimer = 3.0f;
    private float recipeStart;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (recipeTimer == 3.0f)
        { 
                
            toppingUI = toppingGO.GetComponent<Text>();
            liquidUI = liquidGO.GetComponent<Text>();
            anim = receiptGO.GetComponent<Animator>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (recipeTimer > 0)
        {
            recipeTimer -= 1.0f * Time.deltaTime;
        }
        if (recipeTimer < 0.0f)
        {
            switch (lineSwitch)
            {
                case 0:
                    lineSwitch = 1;
                    recipeTimer = 1.0f;
                    liquidUI.text = "Base: " + liquids[Random.Range(0, 2)];
                    
                    
                    break;
                case 1:
                    lineSwitch = 2;
                    recipeTimer = 3.0f;
                    toppingUI.text = "Toppings: " + toppings[Random.Range(0, 1)];
                    break;
                case 2:
                    recipeTimer = 1.0f;
                    lineSwitch = 3;
                    anim.Play("SendToIngredients");
                    break;
                case 3:
                    DontDestroyOnLoad(this.gameObject);
                    SceneManager.LoadScene("IngredientsStation");
                    lineSwitch = 4;
                    break;
                case 4:
                    
                    break;


            }


        }
        if(recipeStart > 0)
        {
            recipeStart -= 1.0f * Time.deltaTime;
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("IngredientsStation") && play == false)
        {
            if (recipeStart <= 0)
            {
                play = true;
                anim.Play("IngredientState");
            }
        }
    }
}

