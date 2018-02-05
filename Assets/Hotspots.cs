using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotspots : MonoBehaviour {

    GameObject hotspot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = 2.0f;       // we want 2m away from the camera position
            var objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            hotspot = GameObject.CreatePrimitive(PrimitiveType.Cube);
            hotspot.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            Instantiate(hotspot, objectPos, Quaternion.identity);
            //hotspot.transform.position = new Vector3(objectPos.x, objectPos.y, objectPos.z);

        }
	}
}
