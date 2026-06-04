using UnityEngine;

public class ShakerSound : MonoBehaviour
{
    public AudioClip shakerSound;
    public AudioSource shakerSource;

    public void PlayShaker()
    {
        shakerSource.PlayOneShot(shakerSound);
    }
}
