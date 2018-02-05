﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour {

    public Material playButtonMaterial;
    public Material pauseButtonMaterial;
    public Renderer screenRenderer;

    private VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayPause(){
        if (videoPlayer.isPlaying){
            videoPlayer.Pause();
            //screenRenderer.material = playButtonMaterial;
        }

        else{
            videoPlayer.Play();
            //screenRenderer.material = pauseButtonMaterial;
        }
            
    }
}
