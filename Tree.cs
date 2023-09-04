using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{

    public float timer = 0f;
    public float growTime = 10f;
    public float maxSize = 7f;

    public bool isMaxSize = false;

    void Start(){
        if(!isMaxSize){
            StartCoroutine(Grow());
        }

    }
    private IEnumerator Grow(){
        Vector3 maxScale = new Vector3(7f, 14f, 7f);
        Vector3 startScale = transform.localScale;

        do{
            transform.localScale = Vector3.Lerp(startScale, maxScale, timer / growTime);
            timer += Time.deltaTime;
            yield return null;
        }
        while(timer < growTime);

        isMaxSize = true;        
    }
    
}
