using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControl : MonoBehaviour {

    float startTime, endTime, swipeDistance, swipeTime;
    public float maxTime, minSwipeDist;
    Vector3 startPos,endPos;
    
    public GameObject player;

    void Start()
    {
       
        

    }

    void Update()
    {
      if(Input.touchCount  > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase== TouchPhase.Began)
            {
                startTime = Time.time;
                startPos = touch.position;
            }

            else if ( touch.phase == TouchPhase.Ended)
            {
                endTime = Time.time;
                endPos = touch.position;

                swipeDistance = (endPos - startPos).magnitude;
                swipeTime = endTime - startTime;

                if(swipeTime < maxTime && swipeDistance > minSwipeDist)
                {
                    Swipe();
                }

            }
        }
    }


    void Swipe()
    {
        Vector2 distance = endPos - startPos;
        if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
            Debug.Log("Swipe!");
        {
            if(distance.y > 0)
            {
                Debug.Log("Jump!");
              //  player.GetComponent<ControlCharacter>().Jump();
              
            }
            else if( distance.y < 0)
            {
                Debug.Log("Nunduk!");
               // anim.SetBool("isNunduk",true);
            }
        }
    }
}

