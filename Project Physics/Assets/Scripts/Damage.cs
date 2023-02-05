using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
	public Animator anim;
	void Start (){
		anim = GetComponent<Animator> ();
	}
	void OnMouseDown(){
		if (OofCount.boom == true) {
			anim.Play ("BOOM");
			Destroy (gameObject,1);
		}
	}
}
