using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoSpeed : MonoBehaviour {

    public VideoPlayer videoPlayer;
    public Text Message;
    public float video360Speed = 0;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        video360Speed = Convert.ToSingle(Message.text, CultureInfo.CreateSpecificCulture("en-US"));
        videoPlayer.playbackSpeed = video360Speed;
	}
}
