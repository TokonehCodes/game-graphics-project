using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLights : MonoBehaviour
{
    public GameObject sun;
    Material light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(sun.transform.rotation.eulerAngles.x > 180){
            light.SetFloat("_AlphaCutoff", 1);
           }
        if(sun.transform.rotation.eulerAngles.x < 180){
            light.SetFloat("_AlphaCutoff", 0);
           }
    }
}
