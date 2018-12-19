using UnityEngine;

[System.Serializable]
public class Sound 
 {

    public string name;// det här namnet

    public AudioClip clip; //det här är själva ljudklippet
    
    [Range(0,1)]
    public float volume; //det här är volymen 
    [Range(0.1f,3)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
