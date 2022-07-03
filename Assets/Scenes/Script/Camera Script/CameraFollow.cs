using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float followSpeed = 20;
    private Transform playerTarget;

    void Awake(){
        playerTarget = GameObject.Find("Robot").transform;
        
    }

 
    void Update(){
        if (playerTarget){
            Vector3 start = transform.position;
            Vector3 pos = new Vector3(playerTarget.position.x, playerTarget.position.y + 3f,
                playerTarget.position.z);

            Vector3 end = Vector3.MoveTowards(start, pos, followSpeed * Time.deltaTime); // a soma dos 2 de cima 

            end.z = start.z;
            transform.position = end;

        }

        
    }
}// class
