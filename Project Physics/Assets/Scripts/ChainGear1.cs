using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainGear1 : MonoBehaviour {
	public 	Animator ChainStart;
	void Start () {
		ChainStart = GetComponent <Animator> ();
	}
	void Update () {
		if (OofCount.qwerty == true) {
			ChainStart.speed = 1;
			ChainStart.Play ("Gear_1");
		} if(OofCount.qwerty == false || TimeCount.timer>1.7f)
			ChainStart.speed = 0;
}
}