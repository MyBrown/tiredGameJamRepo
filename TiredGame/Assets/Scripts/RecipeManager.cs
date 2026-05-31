using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class RecipeManager : MonoBehaviour
{
    private string[] toppings = {"Sugar","Cinnamon"};
    private string[] liquids = { "Tea","Coffee","Water" };
    public GameObject toppingGO;
    public GameObject liquidGO;
    private string liquid;
    private string topping;
    private Text liquidUI;
    private Text toppingUI;
    private int lineSwitch = 0;
    private float recipeTimer = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        toppingUI = toppingGO.GetComponent<Text>();
        liquidUI = liquidGO.GetComponent<Text>();
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
                    recipeTimer = 3.0f;
                    liquidUI.text = "Base: " + liquids[Random.Range(0, 1)];
                    
                    
                    break;
                case 1:
                    lineSwitch = 2;
                    recipeTimer = 3.0f;
                    toppingUI.text = "Topping: " + toppings[Random.Range(0, 2)];
                    break;
            }

        }
    }
}

