using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplayFlow : MonoBehaviour {
	public const int PRE_GAME = 0;
	public const int IN_GAME = 1;
	public const int END_GAME_WON = 2;
	public const int END_GAME_LOST = 3;
	public const int GAME_WAIT = 4;

	public int state;

	public bool result;
	public bool inGame;

	public Text text;
	public Text scoreText;
	public int score;
	// Use this for initialization
	void Start () {
		state = GAME_WAIT;
		result = false;
		inGame = false;
		text.text = "";
		score = 0;
		scoreText.text = "Score: "+ score;
	}
	void updateScore(){

		scoreText.text = "Score: "+ score;
	}	
	// Update is called once per frame
	void Update () {
		switch(state){
			case PRE_GAME:
				//clean all the stuff u drew
				//inGame needs to be changed when triggered.
				updateScore();
				if(inGame){
					state = IN_GAME;
				}
				break;
			case IN_GAME:
				if(!inGame){
					if(result){
						state = END_GAME_WON;
						text.text = "Congratulations!"
						score += 1;
						updateScore();
					} else {
						state = END_GAME_LOST;
						text.text = "Feelsbadman."
					}

				}
				break;
			case END_GAME_WON:
				state = GAME_WAIT;
				break;
			case END_GAME_LOST:
				score = 0;
				state = GAME_WAIT;
				break;
			case GAME_WAIT:
				break;
		}
	}
}
