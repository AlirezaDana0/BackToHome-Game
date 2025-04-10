using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cntrlMusic : MonoBehaviour
{
    public void unMute() {
        GameObject.Find("Music").GetComponent<AudioSource>().Play();
    }
    public void Mute() {
        GameObject.Find("Music").GetComponent<AudioSource>().Stop();
    }
    
}
