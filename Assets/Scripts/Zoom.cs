using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += transform.forward * Time.deltaTime;

        }else if (Input.GetKey(KeyCode.E))
        {
            transform.position -= transform.forward * Time.deltaTime;
        }
    }
}
