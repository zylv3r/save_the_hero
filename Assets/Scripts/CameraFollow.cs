using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public Transform followedObject;
    public float verticalOffset = 0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position = new Vector3(transform.position.x, followedObject.position.y + verticalOffset, -10);
	}
}
