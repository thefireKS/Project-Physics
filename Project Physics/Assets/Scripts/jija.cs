using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jija : MonoBehaviour {
	public Animator anim;
	int i = 0;
	void Start () {
		anim = GetComponent <Animator> ();
	}

	public float qwertyy(float fValue) {
		if (fValue == 2)
			i = 1;
		return fValue;
	}
	public void Update (){
		
		Debug.Log(TimeCount.timer + " " + OofCount.qwerty);
		if (OofCount.qwerty == true && TimeCount.timer > 2.4f) {
			anim.Play ("Water");
			if (i==1)
				anim.speed = 0;
		}
	}
}
