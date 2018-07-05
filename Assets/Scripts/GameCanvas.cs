using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCanvas : MonoBehaviour {

	void Start () {
		if (SceneManager.GetActiveScene ().name == "MainMenu")
			this.gameObject.SetActive (false);
		else {
			Debug.Log ("Not Main menu");
			this.gameObject.SetActive (true);
		}
	}
}
