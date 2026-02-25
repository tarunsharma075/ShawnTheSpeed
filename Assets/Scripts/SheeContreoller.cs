using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EndlesRunning();
        MovementControl();

    }

    void EndlesRunning()
    {
        this.transform.position-= Vector3.left * 2 * Time.deltaTime;
    }

    void MovementControl()
    {
       
        if (Input.GetKey(KeyCode.LeftArrow)){
         this.transform.position += Vector3.forward*Time.deltaTime*2f;
        }else if (Input.GetKey(KeyCode.RightArrow)){
            this.transform.position -= Vector3.forward * Time.deltaTime * 2f;
        }
       
    }

}