using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text scoreText;

    public float scorepoint = 0;

    private float score = 0;

    public float pointsPerSecond;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ScoreUpdate();
        scoreText.text = "Score: " + score;
	}
    public void ScoreUpdate()
    {
        scorepoint += pointsPerSecond * Time.deltaTime;
        
        //show integer value of score
        score = Mathf.Floor(scorepoint);
    }
}
