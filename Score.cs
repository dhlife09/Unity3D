using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	private int score;
	// Use this for initialization
	void InitScore () {
		this.score = 0;
	}

	void AddScore(){
		this.score += score;
	}
	// Update is called once per frame
	void Update () {
		guiText.text = "Score : " + this.score;
	}
}
