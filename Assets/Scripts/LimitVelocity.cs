using UnityEngine;
using System.Collections;

public class LimitVelocity : MonoBehaviour {
    public float topSpeed;
	void Start () {
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        if (rigidbody2D.velocity.magnitude > topSpeed)
            rigidbody2D.velocity = rigidbody2D.velocity.normalized * topSpeed;
    }
}
