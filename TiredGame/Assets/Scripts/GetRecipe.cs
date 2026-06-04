using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GetRecipe : MonoBehaviour
{
    public GameObject toppingGO;
    public GameObject liquidGO;
    public GameObject topping2GO;
  
    private string liquid;
    private string topping;
    private string topping2;
    public static Text liquidUI;
    public static Text toppingUI;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        if (SceneManager.GetActiveScene().name == "IngredientsStation")
        {
            anim.Play("IngredientState");
        }
        liquidUI = liquidGO.GetComponent<Text>();
        toppingUI = toppingGO.GetComponent<Text>();
        liquidUI.text = "Base: " + RecipeManager.ingredientList[0];
        toppingUI.text = "Toppings: "+RecipeManager.ingredientList[1]+"\n"+RecipeManager.ingredientList[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
