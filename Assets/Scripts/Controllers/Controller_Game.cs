using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller_Game : MonoBehaviour {
	
	#region Variables/.. whatever they are called
	public static Controller_Game Instance { get; protected set; }

	//The game data
	public Game game { get; protected set; }

	public GameObject gameCanvas;
	public GameObject menuCanvas;
	#endregion

	#region MonoBehaviours
	//Use this for initialization
	void OnEnable () {
		if(Instance != null) {
			Debug.LogError("There should never be two game controllers.");
		}
		Instance = this;
		DontDestroyOnLoad (this);
		//Create a new game
		game = new Game();
	}

	//Use this for initialization
	void Start () {

		game.SetSceneNames (LoadScenes ());

		//FIXME: Just for debug
		foreach (string s in game.sceneNames) {
			Debug.Log (s);
		}

		SwitchScene ("MainMenu");
	}
	#endregion

	#region Player
	//TODO: Player selection
	#endregion

	#region Scenes
	public string [] LoadScenes (){
		string[] solution;
		DirectoryInfo dir = new DirectoryInfo ("Assets/Scenes/GameModes");
		FileInfo[] files = dir.GetFiles ("*.unity");
		solution = new string[ files.GetLength(0) ];
		for (int i = 0; i < files.GetLength(0); i++) {
			string sceneName = files [i].Name;
			sceneName = sceneName.Substring(0, sceneName.Length - 6);
			solution [i] = sceneName;
		}
		return solution;
	}

	//Switch Game mode by switching scenes
	public void SwitchScene (string name){
		//TODO:: Add a transition effect so it
		// isn't just an instant switch
		SceneManager.LoadScene (name);
		if (name == "MainMenu") {
			menuCanvas.SetActive (false);
			gameCanvas.SetActive (true);
		}
		else {
			menuCanvas.SetActive (true);
			gameCanvas.SetActive (false);
		}
	}

	#endregion
}