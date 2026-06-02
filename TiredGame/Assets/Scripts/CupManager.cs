using UnityEngine;
public class CupManager : MonoBehaviour
{
    public int ingredientNum = 0;
    public SpriteRenderer noIngredient;
    public SpriteRenderer firstIngredient;
    public SpriteRenderer secondIngredient;
    public SpriteRenderer thirdIngredient;

    public GameObject orderUp;

    void Start()
    {
        // makes sure that only the empty cup sprite is active at the start
        noIngredient.enabled = true;
        firstIngredient.enabled = false;
        secondIngredient.enabled = false;
        thirdIngredient.enabled = false;

        orderUp.SetActive(false);

    }

    void Update()
    {
        // turns off all other sprites to prevent them from overlapping when the next one is called
        if (ingredientNum == 1)
        {
            noIngredient.enabled = false;
            firstIngredient.enabled = true;
            secondIngredient.enabled = false;
            thirdIngredient.enabled = false;
        }
        else if (ingredientNum == 2)
        {
            noIngredient.enabled = false;
            firstIngredient.enabled = false;
            secondIngredient.enabled = true;
            thirdIngredient.enabled = false;
        }
        else if (ingredientNum == 3)
        {
            noIngredient.enabled = false;
            firstIngredient.enabled = false;
            secondIngredient.enabled = false;
            thirdIngredient.enabled = true;

            orderUp.SetActive(true);
        }
    }

}
