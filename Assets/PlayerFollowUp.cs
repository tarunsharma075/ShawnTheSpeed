using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowUp : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;


    void Update()
    {
        this.transform.position= playerTransform.position + offset;
    }
}
