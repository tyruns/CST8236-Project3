using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public static float speed = 20.0f;

    public float period;

    void Start () {
	
	}
	void Update () {

        float direction = 1.0f;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            speed += 2.0f;
        }else if (Input.GetKeyDown(KeyCode.X))
        {
            if(speed>2.0f)
            {
                speed -= 2.0f;
            }

        }

        //Goal is to orbit around the sun (earth in the case of the moon) along the xaxis
        if (transform.parent != null)
        {
            transform.RotateAround(transform.parent.position, Vector3.up, (Time.deltaTime / period * speed));
        }
        transform.Rotate(new Vector3(10, 20, 5), (Time.deltaTime*direction*10.0f));

    }
}
