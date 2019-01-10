using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

    public PlayerScript player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstacle(Clone)")
        {
            GetComponent<PlayerScript>().enabled = false;
            FindObjectOfType<ScoreText>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
