using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickScript : MonoBehaviour
{
    public OVRInput.Controller rController = OVRInput.Controller.RTouch;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rControllerPosition = OVRInput.GetLocalControllerPosition(rController);
        Quaternion rControllerRotation = OVRInput.GetLocalControllerRotation(rController);

        transform.position = rControllerPosition;
        transform.rotation = rControllerRotation;
    }
}
