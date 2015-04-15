using UnityEngine;
using System.Collections;

public class cubeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//rotate in the Z axis
		transform.Rotate (Vector3.forward * 10f * Time.deltaTime);

		transform.Rotate (Vector3.left * 10f * Time.deltaTime);


				if (transform.position.z > 0)
						transform.Translate (Vector3.forward * -10f * Time.deltaTime, Space.World);
				else
						transform.position = new Vector3 (0f, 0f, 10f);


	
	}
}
