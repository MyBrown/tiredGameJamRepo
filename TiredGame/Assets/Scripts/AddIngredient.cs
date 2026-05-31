using UnityEngine;

public class AddIngredient : MonoBehaviour
{
    public GameObject cupManager;


    public void OnClick()
    {
        if (cupManager.GetComponent<CupManager>().ingredientNum < 4)
        {
            cupManager.GetComponent<CupManager>().ingredientNum++;
        }
    }
}
