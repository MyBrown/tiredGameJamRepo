using UnityEngine;
using UnityEngine.EventSystems;

public class AddIngredient : MonoBehaviour
{
    public GameObject cupManager;
    public GameObject orderArray;


    public void OnClick()
    {
        if (cupManager.GetComponent<CupManager>().ingredientNum < 4)
        {
            cupManager.GetComponent<CupManager>().ingredientNum++;
            
            orderArray.GetComponent<CurrentOrder>().AddIngredient(EventSystem.current.currentSelectedGameObject.name);
            Debug.Log($"{EventSystem.current.currentSelectedGameObject.name}");
        }
    }
}
