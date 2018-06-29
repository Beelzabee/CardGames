using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game {

	//There should be several different types of card games
	List <GameTypes> gt = new List<GameTypes> ();

	public GameTypes[] ReturnGameTypes (){
		GameTypes[] solution = gt.ToArray ();
		return solution;
	}

}
