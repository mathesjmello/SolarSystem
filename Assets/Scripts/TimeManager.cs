using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour {
    //singleton acesso por static
    public static TimeManager instance;

    public float MyTimeScale = 1;

    public Slider timeslider;
    private float contador;
    private double anocontador;
    public Text Hora;
    public Text Days;
    public Text Year;

    // Use this for initialization
    void Start () {
        instance = this;
    }
    void UpdateSlider()
    {
        timeslider.value = MyTimeScale;
    }
    public void MyPause()
    {
        MyTimeScale = 0;
        UpdateSlider();
    }
    public void MyPlay()
    {
        MyTimeScale = 1;
        UpdateSlider();
    }
    public void MyStill()
    {
        MyTimeScale = 0.01f;
        UpdateSlider();
    }
    public void SetValue(float time)
    {
        MyTimeScale = time;
    }

    void FixedUpdate()
    {
        contador += (Time.fixedDeltaTime / 2) * MyTimeScale;
        anocontador = contador / 365.2536;
        TimeSpan h = TimeSpan.FromDays(contador);
        Hora.text = h.Hours.ToString() + ":" + h.Minutes.ToString();
        Days.text = Mathf.Floor((float)contador).ToString("Day:000");
        Year.text = Mathf.Floor((float)anocontador).ToString("Years:0000");

    }

}
