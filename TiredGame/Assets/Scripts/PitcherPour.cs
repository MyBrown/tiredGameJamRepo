using UnityEngine;

public class PitcherPour : MonoBehaviour
{
    public AudioClip pitcherPour;
    public AudioSource pourSource;

    public void PlayPour()
    {
        pourSource.PlayOneShot(pitcherPour);
    }
}
