using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public float timer = 0f;
    public float lerpTimer = 0f;
    public float disappearTime = 4f;
    public float growTime = 10f;
    public Rigidbody rb;
    public Vector3 startPosition;
    public Vector3 startRotation;

    void Start(){
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    void Update(){
        Disappear();
    }

    void Disappear(){

        float xDiff = startPosition.y - transform.position.y;

        if(xDiff>2f|xDiff<-2f){
            rb.constraints &= ~RigidbodyConstraints.FreezePosition;
            rb.constraints &= ~RigidbodyConstraints.FreezeRotation;
            timer += Time.deltaTime;
            if(timer>=disappearTime){
                timer = 0f;
                Appear();
            }
        }
    }

    void Appear(){
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
        transform.localScale = new Vector3(1f, 1f, 1f);
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        lerpTimer = 0f;

        StartCoroutine(Grow());

    }

    private IEnumerator Grow(){
        Vector3 maxScale = new Vector3(7f, 7f, 7f);
        do{
            transform.localScale = Vector3.Lerp(transform.localScale, maxScale, 0.4f * Time.deltaTime);
            lerpTimer += Time.deltaTime;
            yield return null;
        }
        while(lerpTimer < growTime);
    }
}
