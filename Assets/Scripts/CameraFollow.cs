
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform sheepPlayer;
    [SerializeField] private Vector3 offset;
    
    void Update()
    {
        this.transform.position = sheepPlayer.position-offset;
    }
}
