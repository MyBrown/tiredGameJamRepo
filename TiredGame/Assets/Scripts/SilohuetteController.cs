using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SilohuetteController : MonoBehaviour
{
    public Image silohuetteImage;

    void Start()
    {
        silohuetteImage.enabled = false;
        StartCoroutine(SwitchImages());
    }

    IEnumerator SwitchImages()
    {
        yield return new WaitForSeconds(2f);
        silohuetteImage.enabled = true;
        
    }
}
