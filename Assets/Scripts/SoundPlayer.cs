using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public void PlaySound(AudioClip clip)
    {
        GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
        GetComponent<AudioSource>().clip = clip;
        GetComponent<AudioSource>().Play();
    }
}
