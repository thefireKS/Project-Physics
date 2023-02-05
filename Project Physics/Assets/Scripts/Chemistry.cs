using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chemistry : MonoBehaviour {

	public Material[] mat;
	Renderer rend;
	public MeshRenderer cap;

	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = mat [5];
	}

	void Update () {
		if (OofCount.mix == true&&OofCount.yes==1) {
			cap.enabled = true;
			if (OofCount.elm [0] == OofCount.elm [1] && OofCount.elm [0] != 0) {//Glits+Cu(OH)2
				rend.sharedMaterial = mat [0];
				OofCount.boom = false;
			} else if (OofCount.elm [0] == 3 && OofCount.elm [2] == 1) {//Glits+HNO3
				rend.sharedMaterial = mat [1];
				OofCount.boom = true;
			} else if (OofCount.elm [1] == 1 && OofCount.elm [2] == 2) { //CuOH2+HNO3
				rend.sharedMaterial = mat [2];
				OofCount.boom = false;
			} else if (OofCount.elm [0] > OofCount.elm [1] && OofCount.elm [0] > OofCount.elm [2]) {
				rend.sharedMaterial = mat [3];
				OofCount.boom = false;
			}
			else
				if (OofCount.elm [1] > OofCount.elm [0] && OofCount.elm [1] > OofCount.elm [2]){
				rend.sharedMaterial = mat [4];
				OofCount.boom = false;
			}
			else
			if (OofCount.elm [2] > OofCount.elm [0] && OofCount.elm [2] > OofCount.elm [0]){
				rend.sharedMaterial = mat [5];
				OofCount.boom = false;
			}
		}
		if(OofCount.mix==false)
			cap.enabled = false;
	}
}
