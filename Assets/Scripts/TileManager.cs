using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {


    public GameObject topTile;

    public GameObject currentTile;

    public GameObject obstacle;

   

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
            SpawnObstacle();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnTile()
    {
        currentTile = (GameObject)Instantiate(topTile,currentTile.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
    }
    public void SpawnObstacle()
    {
        int rand = Random.Range(1, 7);

        if(rand<4)
            Instantiate(obstacle, currentTile.transform.GetChild(0).transform.GetChild(rand).position, Quaternion.identity);
        else
        {
            if (rand == 4)//Spawn mid and right obstacles
            {
                Instantiate(obstacle, currentTile.transform.GetChild(0).transform.GetChild(1).position, Quaternion.identity);
                Instantiate(obstacle, currentTile.transform.GetChild(0).transform.GetChild(3).position, Quaternion.identity);
            }
            else if(rand == 5)//Spawn mid and left obstacles
            {
                Instantiate(obstacle, currentTile.transform.GetChild(0).transform.GetChild(1).position, Quaternion.identity);
                Instantiate(obstacle, currentTile.transform.GetChild(0).transform.GetChild(2).position, Quaternion.identity);
            }
            else//spawn left and right obstaces
            {
                Instantiate(obstacle, currentTile.transform.GetChild(0).transform.GetChild(2).position, Quaternion.identity);
                Instantiate(obstacle, currentTile.transform.GetChild(0).transform.GetChild(3).position, Quaternion.identity);
            }
        }
    }
}
