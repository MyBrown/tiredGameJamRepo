using UnityEngine;
using UnityEngine.Playables;

public class AnimationController : MonoBehaviour
{
    //a variable to make sure the animation only plays once at the beginning
    public float playOnce = 0;
    private PlayableDirector director;
    // the object with the timeline in it
    public GameObject timeline;

    void Awake()
    {
        if (playOnce < 1)
        {
            director.Play();
            playOnce = 1;
        }
        else
        {
            timeline.SetActive(false);
        }
    }
}
