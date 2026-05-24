using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wire : MonoBehaviour {


	public void OnMouseDown()
	{
		transform.gameObject.SetActive(false);
		OofCount.elc = false;
	}
}