using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDelay : MonoBehaviour
{
    public Button button;
    private AnimationController animCount;
    void Start()
    {
        button.interactable = false;
        if (animCount.GetComponent<AnimationController>().playOnce < 1){
            Delay(5f);
        }
        else
        {
            Delay(3f);
        }
    }

    IEnumerator Delay(float timer)
    {
        yield return new WaitForSeconds(timer);
        button.interactable = true;
    }
}
