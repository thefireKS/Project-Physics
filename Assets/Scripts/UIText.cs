using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIText : MonoBehaviour {
	public int I;
	void Update (){
		if (OofCount.whc == I) {
			transform.gameObject.SetActive (true);
		}
		else
			transform.gameObject.SetActive (false);
	}
}