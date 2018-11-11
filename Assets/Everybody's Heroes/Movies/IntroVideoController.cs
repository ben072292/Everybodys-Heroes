using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]

public class IntroVideoController : MonoBehaviour {

	// Use this for initialization
	void Start () {

		StartCoroutine (PlayIntro ());

	}

	IEnumerator PlayIntro(){
		MovieTexture IntroMovie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
		GetComponent<AudioSource>().clip = IntroMovie.audioClip;

		GetComponent<AudioSource>().Play ();
		IntroMovie.Play ();
		yield return new WaitForSeconds (IntroMovie.duration);
		Application.LoadLevel("Menu");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
