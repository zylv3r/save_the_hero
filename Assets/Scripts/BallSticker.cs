using UnityEngine;
using System.Collections;

public class BallSticker : MonoBehaviour {
    public GameObject ball;
    public float exhaust = .1f;//ms
    private float lastUsed = 0f;
	void Start () {
	
	}
	
	void FixedUpdate ()
    {
        if (Input.GetMouseButtonUp(0) && ((Time.time - lastUsed) >= exhaust))
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = -5;
            GameObject newBall = (GameObject)Instantiate(ball, position, transform.rotation);
            lastUsed = Time.time;
        }
	}
}
