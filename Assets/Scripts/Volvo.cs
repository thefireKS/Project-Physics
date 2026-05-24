using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volvo : MonoBehaviour {
	public Animator anim;
	void Start () {
		anim = GetComponent <Animator> ();
	}
	void Update () {
		if (OofCount.qwerty == true&&TimeCount.timer>1.9f) {
			anim.speed = 1;
			anim.Play ("valvee");
		} if(OofCount.qwerty == false || TimeCount.timer>2.9f)
			anim.speed = 0;
	}
}
