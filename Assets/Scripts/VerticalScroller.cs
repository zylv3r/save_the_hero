using UnityEngine;
using System.Collections;

public class VerticalScroller : MonoBehaviour {
    public Transform[] backgrounds = new Transform[2];
    public static Transform currentBackground;
	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
        if (backgrounds != null)
        {
            Transform notColliding = null, colliding = null;
            foreach (var item in backgrounds)
            {
                BackgroundColliderDetector detector = item.GetComponent<BackgroundColliderDetector>();
                if (detector)
                {
                    if (!detector.colliding)
                    {
                        notColliding = item;
                    }
                    else
                    {
                        colliding = item;
                    }
                }
            }

            if (notColliding && colliding)
            {
                if (currentBackground != colliding)//swap it
                {
                    notColliding.position = new Vector3(colliding.position.x, colliding.position.y - colliding.renderer.bounds.size.y, colliding.position.z);

                    //clean the balls for this
                    /*for (int i = 0; i < notColliding.childCount; i++)
                    {
                        Transform child = notColliding.GetChild(i);
                        if (child.tag == "Ball")
                        {
                            Destroy(child.gameObject);
                        }
                    }*/

                    if (currentBackground == null)
                    {
                        StageGenerator stgComp = colliding.GetComponent<StageGenerator>();
                        if (stgComp)
                        {
                            stgComp.GenerateStage();
                        }
                    }
                    StageGenerator stgComp2 = notColliding.GetComponent<StageGenerator>();
                    if (stgComp2)
                    {
                        stgComp2.GenerateStage();
                    }
                    currentBackground = colliding;
                }
            }
        }
	}
}
