using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManeger : MonoBehaviour {

    public static TimeManeger instance;
    public float MyTimeScale = 1;
    public Slider TimeSlider;
	// Use this for initialization
	void Start () {
		instance=this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void UpdateSlider()
    {
        TimeSlider.value = MyTimeScale;
    }
    public void MyPause()
    {
        MyTimeScale = 0;
        UpdateSlider();
    }
    public void MyStillSlow()
    {
        MyTimeScale = 0.5f;
        UpdateSlider();
    }
    public void MyPlay()
    {
        MyTimeScale = 1;
        UpdateSlider();
    }
    public void SetValue(float time)
    {
        MyTimeScale = time;
    }

}
