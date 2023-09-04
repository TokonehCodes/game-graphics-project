using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Profiling;

public class gameStats : MonoBehaviour
{
    public float timer, refresh, avgFrameRate;
    public string display = "{0} FPS";
    public Text fpsText;
    public Text resMem;
    public Text allocMem;

    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= Time.deltaTime;
        if(timer <=0) avgFrameRate = (int) (1f / timelapse);
        fpsText.text = string.Format(display, avgFrameRate.ToString());


        resMem.text = "ReservedMem: " + UnityEngine.Profiling.Profiler.GetTotalReservedMemoryLong();
        allocMem.text = "AllocatedMem: " + UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong();


    }
}

