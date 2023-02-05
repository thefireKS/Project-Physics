using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampColorSwap : MonoBehaviour {

	public Material[] mat;
	Renderer rend;

	void Start ()
	{
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = mat[0];
	}

	void Update ()
	{
		if(OofCount.elc == false||OofCount.Clr==-1)
			rend.sharedMaterial = mat [0];
		if (OofCount.Clr == 0&&OofCount.elc == true)
			GetComponent<Renderer>().material.color = Color.white;
		if(OofCount.Clr == 1&&OofCount.elc == true)
			GetComponent<Renderer>().material.color = Color.red;
		if(OofCount.Clr == 2&&OofCount.elc == true)
			GetComponent<Renderer>().material.color = Color.blue;		
		if(OofCount.Clr == 3&&OofCount.elc == true)
			GetComponent<Renderer>().material.color = Color.green;
		if(OofCount.Clr == 4&&OofCount.elc == true)
			GetComponent<Renderer>().material.color = Color.yellow;
		if(OofCount.Clr == 5&&OofCount.elc == true)
			GetComponent<Renderer>().material.color = Color.magenta;
	}
}
