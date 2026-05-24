using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangHammer : MonoBehaviour {
	public Animator anim;
	void Start () {
		anim = GetComponent <Animator> ();
	}
	int i = 0;
	//функция остановки молотка через флажки
	public float qwertyy(float fValue) {  
		if (fValue == 2)
			i = 1;
		return fValue;
	}
	public void Update (){

		if (OofCount.qwerty == true && TimeCount.timer > 0.8f) {
			anim.Play ("hammer");
			if (i==1)
				anim.speed = 0;
			
		}
	}
}
