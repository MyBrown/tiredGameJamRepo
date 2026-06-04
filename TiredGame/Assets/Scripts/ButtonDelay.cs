using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDelay : MonoBehaviour
{
    public Button button;
    public AnimationController animCount;
    void Start()
    {
        button.interactable = false;

        if (animCount.GetComponent<AnimationController>().playOnce < 1){
            StartCoroutine(Delay(2f));
        }
        else
        {
            StartCoroutine(Delay(3.5f));
        }
    }

    IEnumerator Delay(float timer)
    {
        yield return new WaitForSeconds(timer);
        button.interactable = true;
    }
}
