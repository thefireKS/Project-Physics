using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour {
	public Animation anim;
	void Start () {
		anim = GetComponent <Animation> ();
	}
	private void OnMouseDown ()
	{
		TimeCount.timer = 0f;
		anim.Play ("Chain");
		if (OofCount.qwerty == false) {
			OofCount.qwerty = true;
		}
		else{
			OofCount.qwerty = false;
		}
	}
}