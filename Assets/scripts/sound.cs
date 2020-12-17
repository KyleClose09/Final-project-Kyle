using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class sound

{
    public string name;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(.1f, 3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
    //allows us to set up the options for our sound manager with volume, pitch and 
    //a looping option
}