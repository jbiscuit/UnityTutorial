using UnityEngine;
using System.Collections;

public class MusicHelper : MonoBehaviour {

	void Awake ()
	{
		DontDestroyOnLoad(gameObject.audio);
	}
}