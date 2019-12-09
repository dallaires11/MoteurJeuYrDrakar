using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotationCollectible : MonoBehaviour { 
public Transform pivot; // le pivot (ici l'arme)

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {

        Vector3 targetP = pivot.position; // position du pivot
        transform.RotateAround(targetP, Vector3.up, 50 * Time.deltaTime); // rotation du cylindre autour du pivot

    }
    
}
