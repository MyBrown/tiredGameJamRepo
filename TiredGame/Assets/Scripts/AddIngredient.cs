using UnityEngine;

public class AddIngredient : MonoBehaviour
{
    public GameObject cupManager;


    public void OnClick()
    {
        while (cupManager.GetComponent<CupManager>().ingredientNum < 4)
        {
            cupManager.GetComponent<CupManager>().ingredientNum++;
        }
        Debug.Log("No more ingredients can be added");
    }
}
