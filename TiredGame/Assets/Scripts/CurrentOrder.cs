using UnityEngine;

public class CurrentOrder : MonoBehaviour
{
    private string[] ingredientsArray = {null, null, null};
    // how we get access to the CupManager script
    public GameObject cupManager;

    public void AddIngredient(string ingredient)
    {
        var i = cupManager.GetComponent<CupManager>().ingredientNum - 1;
        ingredientsArray[i] = ingredient;
    }
}
