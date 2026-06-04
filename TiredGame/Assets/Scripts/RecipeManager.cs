using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class RecipeManager : MonoBehaviour
{
    private string[] toppings = {"sugar","cinnamon","milk","mocha","sprinkles"};
    private string[] liquids = { "tea","coffee","milk"};
    public static string[] ingredientList;
    public GameObject toppingGO;
    public GameObject liquidGO;
    public GameObject topping2GO;
    public GameObject receiptGO;
    public GameObject customerGO;
    private string liquid;
    private string topping;
    private string topping2;
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
            ingredientList = new string[3];
            liquid = liquids[Random.Range(0, 2)];
            topping = toppings[Random.Range(0, 4)];
            topping2 = toppings[Random.Range(0, 4)];
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
                   
                    recipeTimer = 1.0f;
                    liquidUI.text += liquid;
                    ingredientList[0] = liquid;
                    lineSwitch = 1;
                    break;
                case 1:
                   
                    recipeTimer = 1.0f;
                    toppingUI.text += topping;
                    ingredientList[1] = topping;
                    lineSwitch = 2;  
                    break;
                case 2: 
                    recipeTimer = 1.0f;
                    toppingUI.text += "\n"+topping2;
                    ingredientList[2] = topping2;
                    lineSwitch = 3;
                    break;
                case 3:
                    recipeTimer = 2.0f;
                    lineSwitch = 4;
                    anim.Play("SendToIngredients");
                    break;
                case 4:
                    DontDestroyOnLoad(this.gameObject);
                    SceneManager.LoadScene("IngredientsStation");
                    lineSwitch = 5;
                    break;
                case 5:

                    break;


            }


        }
        if(recipeStart > 0)
        {
            recipeStart -= 1.0f * Time.deltaTime;
        }
        if (SceneManager.GetActiveScene().name == "OrderUp")
        {
            
                anim.Play("TakeOrder");
            
        }
        if (SceneManager.GetActiveScene().name == "IngredientsStation" && play == false)
        {
            if (recipeStart <= 0)
            {
                play = true;
                anim.Play("IngredientState");
            }
        }
        if (SceneManager.GetActiveScene().name == "OrderUp")
        {
            if (NextCustomer.destroyGO > 3)
            {
                Destroy(this.gameObject);
            }
            customerGO.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name == "Chris' testing scene")
        {
            customerGO.SetActive(true);
        }
        else
        {
            customerGO.SetActive(false);
        }

       
    }
}

