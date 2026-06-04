using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SilohuetteController : MonoBehaviour
{
    public Image silohuetteImage;
    public AnimationController animCount;

    void Start()
    {   
        silohuetteImage.enabled = false;

        if (animCount.GetComponent<AnimationController>().playOnce < 1)
        {
            StartCoroutine(SwitchImages(2f));
        }
        else {
            StartCoroutine(SwitchImages(3.5f));
        }
    }

    IEnumerator SwitchImages(float timer)
    {
        yield return new WaitForSeconds(timer);
        silohuetteImage.enabled = true;
        
    }
}
