using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] float speed;


    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left*speed*Time.deltaTime;
        if (transform.position.x < -10){
            Destroy (gameObject);
        }
    }
}
