using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dose : MonoBehaviour {
	public int n;
	public TextMesh prop;

	void Start () {
		prop = GetComponent<TextMesh> ();
	}

	void Update () {
		prop.text = " " + OofCount.elm [n];
	}
}
