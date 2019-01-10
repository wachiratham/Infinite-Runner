using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {


    private const float LANE_DISTANCE = 0.25f;

    private float velocity = 3.0f;

    private int lane = 1; // 0 = Left, 1 = Middle, 2 = Right

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //Get lane
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Left");
            MoveLane(0); //Move Left
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Right");
            MoveLane(1); //Move Right
        }

        //Calculate Position
        Vector3 targetPosition = transform.position.z * Vector3.forward; //(0,0,z)
        if (lane == 0)
            targetPosition += Vector3.left * LANE_DISTANCE; //(-0.25,0,z)
        else if (lane == 2)
            targetPosition += Vector3.right * LANE_DISTANCE; //(0.25,0,z)

        //Calculate move delta
        Vector3 moveVector = Vector3.zero;
        moveVector.x = (targetPosition - transform.position).normalized.x * velocity;
        moveVector.y = 0;
        moveVector.z = velocity;

        //Move
        transform.position += moveVector * Time.deltaTime;

    }
    private void MoveLane(int direction)
    {
        if(direction == 0)
        {
            lane--;
            if (lane == -1)
                lane = 0;
        }
        else
        {
            lane++;
            if (lane == 3)
                lane = 2;
        }
    }
}
