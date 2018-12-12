using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] Sounds; // an array of sound clips

    void Awake()
    {
        foreach (Sound s in Sounds) //för varje ljudclip i "Sounds" arrayen 
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(Sounds, Sound => Sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound" + name + "not found!");
            return;
        }
        s.source.Play();
    }
}
