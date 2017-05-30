using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveFromRight : MonoBehaviour {

    public GameObject Character;
    float x = 7f;
    float y, z = 0.00F;
    
    public float speedMin;
    public float speedMax;
   

 //   enum EnemyState { Normal, Dying };

 //   private EnemyState _state;

    // Use this for initialization.
    void Start()
    {
        float thisSpeed = Random.Range(speedMin, speedMax);
        this.GetComponent<Rigidbody>().velocity = Vector3.right * thisSpeed;
       
    }

    void Update()
    {
        transform.Translate(x, y, z);
    }

}
