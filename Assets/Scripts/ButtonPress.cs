using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour {
	public Animation Anime;
	void Start (){
		Anime = GetComponent <Animation> ();
	}
	private void OnMouseDown (){
		if (OofCount.Clr != -1)
			OofCount.Clr = -1;
		else
			OofCount.Clr = 0;
		Anime.Play ("Pressing");
	}
}
