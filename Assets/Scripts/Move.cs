using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    private bool isMoving;
    private bool forward;
    private bool rotate;

    private float direction = 1.0f; //just to initialize

    // Update is called once per frame
    void Update () {

        //These will determine the type of movement
        isMoving = false;
        forward = true;
        rotate = false;

        if (Input.GetKey(KeyCode.W))
        {
            isMoving = true;
            forward = true;
        }else if (Input.GetKey(KeyCode.S))
        {
            isMoving = true;
            forward = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rotate = true;
            direction = 1.0f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            
            rotate = true;
            direction = -1.0f;
        }

        //Handle rotation here

        if (rotate)
        {
            Vector3 rotateTo = transform.rotation.eulerAngles;
            rotateTo.y += Time.deltaTime * direction * 40.0f;
            transform.rotation = Quaternion.Euler(0, rotateTo.y, 0);
        }
        //Handle forward backward movement here
        if (isMoving)
        {

            if (forward) {
                transform.position += transform.forward * Time.deltaTime;
            }
            else { transform.position -= transform.forward * Time.deltaTime; }
  
        }
    }
}
