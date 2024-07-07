using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FrameRate : MonoBehaviour
{
    public int rangeInt;
    public float updateInterval = 0.5F;
    private float accum = 0;
    private int frames = 0;
    private float timeleft;
    private string stringFps;

    public TMP_Text fps;

    void Start()
    {
        timeleft = updateInterval;
        Application.targetFrameRate = 90;
    }

    void Update()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;
        if (timeleft <= 0.0)
        {
            float fps = accum / frames;
            string format = System.String.Format("{0:F2} FPS", fps);
            stringFps = format;
            timeleft = updateInterval;
            accum = 0.0F;
            frames = 0;
        }
        fps.text = stringFps;
    }
}
