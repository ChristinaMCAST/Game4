using UnityEngine;
//for the text elements
using UnityEngine.UI;
using System.Collections;

public class mousecubeController : MonoBehaviour {


	//1. add a reference for the text fields
	public Text mousePosText;
	public Text cubePosText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//2. read the mouse x and y position
		mousePosText.text = "M X:" + Input.mousePosition.x + " Y:" + Input.mousePosition.y;

		//3. translate the mouse coordinates to viewport coordinates
		Vector3 mouseCubePos = Camera.main.ScreenToViewportPoint (Input.mousePosition);

		//4. fix the Z to 10
		mouseCubePos = new Vector3 (mouseCubePos.x, mouseCubePos.y, 10f);


		//5. set the cube x,y position text
		cubePosText.text = "C X:" + mouseCubePos.x + " Y:" + mouseCubePos.y;


		//6. set the mouse cube position
		transform.position = mouseCubePos;

	}
}
