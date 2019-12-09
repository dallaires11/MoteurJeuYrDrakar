using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POVController : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform Player;
    public Camera FirstPersonCam, ThirdPersonCam;
    public KeyCode TKey;
    public bool camSwitch = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            camSwitch = !camSwitch;
            FirstPersonCam.gameObject.SetActive(camSwitch);
            ThirdPersonCam.gameObject.SetActive(!camSwitch);
        }
    }
}
