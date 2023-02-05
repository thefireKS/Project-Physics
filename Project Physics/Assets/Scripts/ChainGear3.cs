using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainGear3 : MonoBehaviour {
	public 	Animator ChainStart;
	void Start () {
		ChainStart = GetComponent <Animator> ();
	}
	void Update () {
		if (OofCount.qwerty == true&&TimeCount.timer>0.6f) {
			ChainStart.speed = 1;
			ChainStart.Play ("Gear_3");
		} if(OofCount.qwerty == false || TimeCount.timer>2.3f)
			ChainStart.speed = 0;
	}
}
