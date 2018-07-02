using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game {

	//There should be several different types of card games
	public string[] sceneNames { get; protected set; }

	public Game (){
		sceneNames = new string[0];
	}

	public void SetSceneNames (string [] sceneNames){
		this.sceneNames = sceneNames;
	}


}
