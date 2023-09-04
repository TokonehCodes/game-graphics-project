using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTornado : MonoBehaviour
{
    Animator anim1;
    // Start is called before the first frame update
    void Start()
    {
        anim1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)){
            anim1.SetTrigger("Play");
            anim1.SetTrigger("Stop");
        }
    }
}
