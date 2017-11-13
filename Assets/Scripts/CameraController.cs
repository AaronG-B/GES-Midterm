using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {



    [SerializeField]
    Transform objectToFollow;
    [SerializeField]
    float xOffset;
    [SerializeField]
    float yOffset;

    float zOffset = -10f;


    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //where to put the camera
        Vector3 newPosition = new Vector3(objectToFollow.position.x + xOffset, objectToFollow.position.y + yOffset, zOffset);
        transform.position = newPosition;
		
	}
}
