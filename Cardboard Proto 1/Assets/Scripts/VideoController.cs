using UnityEngine;
using System.Collections;

public class VideoController : MonoBehaviour {
    public GameObject VideoSphere;
    public CardboardAudioSource AudioSource;
	
    // Play video and audio at start of demo
	void Start () {
        //((MovieTexture)VideoSphere.GetComponent<Renderer>().material.mainTexture).Play();
        //AudioSource.Play();
    }
}
