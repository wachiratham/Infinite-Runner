using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform lookAt;
    public Vector3 offset = new Vector3(0, 0f, -0.2f);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {

        Vector3 position = lookAt.position + offset;
        position.x = 0;
        transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime);
	}
}
