using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinfo : MonoBehaviour {

	public void YesImHere ()
	{
		OofCount.whc = 3;
		OofCount.yes = 1;
	}
	public void NoImLost ()
	{
		OofCount.whc = 0;
		OofCount.yes = 0;
	}
}
