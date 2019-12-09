using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCamera : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    private Vector3 offset;
    private float y;
    private Vector3 rotationY;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        y = player.transform.localRotation.y;
        transform.rotation = player.transform.localRotation; 
    }
}
