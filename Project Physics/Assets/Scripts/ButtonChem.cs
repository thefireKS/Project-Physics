using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChem : MonoBehaviour {
	public Animation anim;
	void Start (){
		anim = GetComponent<Animation> ();
	}
	void OnMouseDown(){
		anim.Play ("But");
		if (OofCount.mix == true)
			OofCount.mix = false;
		if (OofCount.elm [0] != 0 && OofCount.elm [1] != 0 && OofCount.elm [2] != 0)
			OofCount.mix = false;
		else
			OofCount.mix = true;
	}
}
