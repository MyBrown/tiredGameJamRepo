using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDelay : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button.interactable = false;
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        button.interactable = true;
    }
}
