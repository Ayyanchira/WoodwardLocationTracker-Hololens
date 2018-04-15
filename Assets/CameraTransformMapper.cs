using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraTransformMapper : NetworkBehaviour {
    Transform cameraTransform;
    bool isServerCameraActive = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (isClient)
        {
            
            if (isServerCameraActive == true){
                GameObject serverCamera = GameObject.FindGameObjectWithTag("ServerCamera");
                serverCamera.SetActive(false);
                isServerCameraActive = false;
            }
            GameObject hololensComponents = GameObject.FindGameObjectWithTag("MainCamera");
            cameraTransform = hololensComponents.transform;
            //cameraTransform = GetComponent<DeviceSceneSwitcher>().hololensObjects[0].transform;
            this.transform.position = cameraTransform.position;
        }
        
	}
}
