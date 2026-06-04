using NUnit.Framework;
using System;
using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentOrder : MonoBehaviour
{
    private string[] ingredientsArray = { null, null, null };
    
    // how we get access to the CupManager script
    public GameObject cupManager;
    
   
    public void AddIngredient(string ingredient)
    {
        var i = cupManager.GetComponent<CupManager>().ingredientNum - 1;
       
        ingredientsArray[i] = ingredient;
    }

    public void Update()
    {


        if (SceneManager.GetActiveScene().name == "OrderUp")
        {
            foreach (string o in RecipeManager.ingredientList)
            {
                
                if(ingredientsArray.Contains(o))
                {
                    Debug.Log(o);
                }
                else
                {
                    Debug.Log("We ain't got that: " + o);
                }

            }
        }
      
        
    }
}

