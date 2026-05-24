using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Restart : MonoBehaviour {

	public void RestartGame() {
		SceneManager.LoadScene("Lab"); // loads current scene
		OofCount.Oof = 0;
		OofCount.qwerty = false;
		OofCount.Clr = -1;
		OofCount.elc = true;
		OofCount.whc = 0;
		OofCount.elm [0] = 0;
		OofCount.elm [1] = 0;
		OofCount.elm [2] = 0;
		OofCount.mix=false;
		OofCount.boom = false;
		OofCount.yes = 0;
	}


}