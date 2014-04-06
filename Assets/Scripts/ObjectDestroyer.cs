using UnityEngine;
using System.Collections;

public class ObjectDestroyer : MonoBehaviour {
    public float life;
    private float start;
	void Start () {
        start = Time.time;
	}
	
	void Update () {
        if (Time.time - start > life)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
