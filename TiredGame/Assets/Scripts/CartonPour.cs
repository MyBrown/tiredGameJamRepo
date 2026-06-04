using UnityEngine;

public class CartonPour : MonoBehaviour
{
    public AudioClip cartonPour;
    public AudioSource pourSource;

    public void PlayPour()
    {
        pourSource.PlayOneShot(cartonPour);
    }
}
