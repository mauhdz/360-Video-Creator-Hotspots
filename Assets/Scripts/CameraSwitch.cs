using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    public GameObject cam360;
    public GameObject cam_latlong;
    public GameObject surface360;

    //AudioListener cam360AudioLis;
    //AudioListener cam_latlongAudioLis;



	// Use this for initialization
	void Start () {
        //cam360AudioLis = cam360.GetComponent<AudioListener>();
        //cam_latlongAudioLis = cam_latlong.GetComponent<AudioListener>();

        surface360.SetActive(true);
        //cam360AudioLis.enabled = true;
        cam360.SetActive(true);

        //cam_latlongAudioLis.enabled = false;
        cam_latlong.SetActive(false); 
		
	}
	

    public void switchCamera(){
        if(cam360.activeSelf){
            //cam360AudioLis.enabled = false;
            cam360.SetActive(false);
            surface360.SetActive(false);
            cam_latlong.SetActive(true);
        }

        else{
            //cam_latlongAudioLis.enabled = false;
            cam_latlong.SetActive(false);
            surface360.SetActive(true);
            cam360.SetActive(true);
        }
    }
}
