using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {


	public GameObject cube;
	public Camera maincamera;
	int count = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){

			Vector3 position = Input.mousePosition;
			position.z = 10;
			Vector3 screenToWorldPointPosition = maincamera.ScreenToWorldPoint(position);
			
             GameObject cubeOb =  Instantiate(cube,screenToWorldPointPosition,Quaternion.Euler(45,45,45));

			 cubeOb.name = count.ToString();
			 count++;
    	}

	}
}
