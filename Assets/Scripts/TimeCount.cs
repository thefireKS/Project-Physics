using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour {

	public static float timer=0f;

	void Update () {
		timer += Time.deltaTime;
	}
}