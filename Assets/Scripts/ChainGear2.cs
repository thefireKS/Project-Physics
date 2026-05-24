using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainGear2 : MonoBehaviour {
	public Animator anim;
	void Start () {
		anim = GetComponent <Animator> ();
	}
	void Update () {
		if (OofCount.qwerty == true&&TimeCount.timer>0.3f) {
			anim.speed = 1;
			anim.Play ("Gear_2");
		} if(OofCount.qwerty == false || TimeCount.timer>2f)
			anim.speed = 0;
	}
}
