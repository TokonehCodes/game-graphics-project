using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavCamera : MonoBehaviour
{
    public float speed = 40f;


    // Update is called once per frame
    void Update()
    {
        Vector3 deltaPos = Vector3.zero;
		deltaPos.x = Input.GetAxis("Horizontal");
		deltaPos.z = Input.GetAxis("Vertical");
        deltaPos.y = Input.GetAxis("Jump");
		transform.position += deltaPos * speed * Time.deltaTime;


        float rotateDir = 0f;
        if (Input.GetKey(KeyCode.D)) rotateDir += 1f;
        if (Input.GetKey(KeyCode.A)) rotateDir -= 1f;
        transform.eulerAngles += new Vector3(0, rotateDir * Time.deltaTime * 100f, 0);
    }
}
