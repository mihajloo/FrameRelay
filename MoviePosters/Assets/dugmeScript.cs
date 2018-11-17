using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
//using Vuforia;

public class dugmeScript : MonoBehaviour {
    public Button dugme;
    public VideoPlayer video; 

	// Use this for initialization
	void Start () {
        dugme.onClick.AddListener(TaskOnClick);
	}
	public void TaskOnClick(){
        if (video.isPlaying){
            video.Pause();
        }
        else
        {
            video.Play();
        }

    }
	// Update is called once per frame
	void Update () {
		
	}
}
