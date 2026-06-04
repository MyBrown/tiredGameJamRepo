using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SilohuetteController : MonoBehaviour
{
    public Image silohuetteImage;
    private AnimationController animCount;

    void Start()
    {   
        silohuetteImage.enabled = false;
        if (animCount.GetComponent<AnimationController>().playOnce < 1)
        {
            SwitchImages(5f);
        }
        else {
            SwitchImages(3f);
        }
    }

    IEnumerator SwitchImages(float timer)
    {
        yield return new WaitForSeconds(timer);
        silohuetteImage.enabled = true;
        
    }
}
