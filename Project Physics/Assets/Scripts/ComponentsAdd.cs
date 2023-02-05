using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentsAdd : MonoBehaviour {
	public int i;
	public int comp;
	void OnMouseDown(){
		OofCount.elm [i] += comp;
		if (OofCount.elm [i] > 3)
			OofCount.elm [i] = 3;
		if (OofCount.elm [i] < 0)
			OofCount.elm [i] = 0;
	}
}
