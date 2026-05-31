using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class RecipeManager : MonoBehaviour
{
    private string[] toppings = {"Sugar","Cinnamon"};
    private string[] liquids = { "Tea","Coffee","Water" };
    public GameObject toppingGO;
    public GameObject liquidGO;
    private string liquid;
    private string topping;
    public static Text liquidUI;
    public static Text toppingUI;
    private int lineSwitch = 0;
    public static float recipeTimer = 3.0f;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (recipeTimer == 3.0f)
        { 
                
            toppingUI = toppingGO.GetComponent<Text>();
            liquidUI = liquidGO.GetComponent<Text>();
            anim = GetComponent<Animator>();
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
                    liquidUI.text = "Base: " + liquids[Random.Range(0, 1)];
                    
                    
                    break;
                case 1:
                    lineSwitch = 2;
                    recipeTimer = 3.0f;
                    toppingUI.text = "Toppings: " + toppings[Random.Range(0, 2)];
                    break;
                case 2:
                    recipeTimer = 3.0f;
                    lineSwitch = 3;
                    anim.Play("SendToIngredients");
                    break;
                case 3:
                    SceneManager.LoadScene("IngredientsStation");
                    lineSwitch = 4;
                    break;
                case 4:
                    //SceneManager.MoveGameObjectToScene(this.gameObject, SceneManager.GetSceneByName("IngredientsStation"));
                    
                    break;


            }


        }
    }
}

