using UnityEngine;
using System.Collections;

public class BackgroundColliderDetector : MonoBehaviour {
    public bool colliding = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        colliding = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        colliding = false;
    }
}
