using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampColor : MonoBehaviour {
	public int ColourOfLamp;

	private void OnMouseDown ()
	{
		OofCount.Clr = ColourOfLamp;
	}
}
