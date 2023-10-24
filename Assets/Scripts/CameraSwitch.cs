using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitch : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    public CinemachineFreeLook cam2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            cam.Priority = 10;
            cam2.Priority = 9;
            //cam.gameObject.SetActive(true);
            //cam2.gameObject.SetActive(false);
        }
    }  

    private void OnTriggerExit(Collider other)
    {
        cam.Priority = 9;
        cam2.Priority = 10;
        //cam2.gameObject.SetActive(true);
        //cam.gameObject.SetActive(false);
    }
}
