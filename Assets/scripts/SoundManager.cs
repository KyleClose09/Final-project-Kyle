using UnityEngine;
using UnityEngine.Audio;
using System;

public class SoundManager : MonoBehaviour
{
    public sound[] sounds;

    private void Awake()
    {
        foreach (sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            //this lets me set the values needed to edit sounds on the fly with options
        }
    }
    void Start()
    {
        Play("theme");//will play theme of the start
    }
    public void Play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("sound: " + name + "not found");
            return;
        }
        s.source.Play();
        //allows us to search the sound by name and give us a warning if not found
        //if found it will play

    }
}