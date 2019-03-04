using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour 
{
	static MusicPlayer musicPlayer = null;
	// Use this for initialization

	void Awake()
	{
		if (musicPlayer != null) 
		{	
			Destroy (gameObject);
		} else {
			musicPlayer = this;
			//here gameObject is for complete Music Player Object which is declared in Unity
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
