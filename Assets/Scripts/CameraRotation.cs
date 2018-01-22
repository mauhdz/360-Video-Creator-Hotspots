using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

    private float mouseX;
    private float mouseY;

    //Degrees
    private float verticalRotationMin = 0f;
    private float verticalRotationMax = 65f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        HandleMouseRotation();
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y;

	}

    public void HandleMouseRotation(){
        var easeFactor = 10f;

        if(Input.GetMouseButton(0)){
            //Handles horizontal rotation
            if (Input.mousePosition.x != mouseX)
            {
                var cameraRotationY = (Input.mousePosition.x - mouseX) * easeFactor * Time.deltaTime;
                this.transform.Rotate(0, cameraRotationY, 0);
            }
            //Handles vertical rotation

            if(Input.mousePosition.y != mouseY){
                GameObject MainCamera = this.gameObject.transform.Find("Main Camera").gameObject;
                var cameraRotationX = (mouseY - Input.mousePosition.y)*easeFactor*Time.deltaTime;
                MainCamera.transform.Rotate(cameraRotationX,0,0);
            }
        }
    }
}
