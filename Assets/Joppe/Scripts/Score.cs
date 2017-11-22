using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public int score;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(score);
        scoreText.text = "Score: " + score;
    }
}
