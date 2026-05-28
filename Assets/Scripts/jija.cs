using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jija : MonoBehaviour {
	public Animator anim;
	int i = 0;
	bool isPlaying = false;
	void Start () {
		anim = GetComponent <Animator> ();
	}

	public float qwertyy(float fValue) {
		if (fValue == 2)
			i = 1;
		return fValue;
	}
	public void Update (){
		if (OofCount.qwerty == true && TimeCount.timer > 2.4f) {
			if (!isPlaying) {
				i = 0;
				anim.speed = 1;
				anim.Play ("Water", 0, 0f);
				isPlaying = true;
			}
			if (i==1)
				anim.speed = 0;
		} else {
			isPlaying = false;
		}
	}
}
