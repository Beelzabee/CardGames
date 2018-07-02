using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Menus : MonoBehaviour {
	public static Controller_Menus Instance { get; protected set; }

	#region MonoBehaviours
	//Use this for initialization
	void OnEnable () {
		if(Instance != null) {
			Debug.LogError("There should never be two menu controllers.");
		}
		Instance = this;
		DontDestroyOnLoad (this);
	}

	#endregion
}
