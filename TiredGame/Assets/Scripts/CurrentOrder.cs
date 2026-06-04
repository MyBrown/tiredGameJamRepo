using NUnit.Framework;
using System;
using System.Linq;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentOrder : MonoBehaviour
{
    private string[] ingredientsArray = { null, null, null };
    public int finished = 0;
    public int ingredientInt = 0;
   
    // how we get access to the CupManager script
    public GameObject cupManager;
    public GameObject victoryUI;
    public GameObject failUI;
    
   
    public void AddIngredient(string ingredient)
    {
        var i = cupManager.GetComponent<CupManager>().ingredientNum - 1;
       
        ingredientsArray[i] = ingredient;
    }

    public void Update()
    {


        if (SceneManager.GetActiveScene().name == "OrderUp" && finished == 0)
        {
            foreach (string o in RecipeManager.ingredientList)
            {
                
                if(ingredientsArray.Contains(o))
                {
                    ingredientInt += 1;
                    Debug.Log(o +" was found.");
                    
                }
                else
                {

                    Debug.Log("We ain't got that: " + o);
                }

            }
            if(ingredientInt == 3)
            {

            Instantiate(victoryUI);
                Debug.Log("You did it!");

            }
            else
            {
                Instantiate(failUI);
                failUI.SetActive(true);
                Debug.Log("You're fired!");
            }
            finished = 1;
        }
      
        
    }
}

