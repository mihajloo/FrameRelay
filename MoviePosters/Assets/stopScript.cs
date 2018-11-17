using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class stopScript : MonoBehaviour {
    public Button dugme;
    public VideoPlayer video;

    // Use this for initialization
    void Start()
    {
        dugme.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    {
        video.Stop();

    }
    // Update is called once per frame
    void Update()
    {

    }
}
