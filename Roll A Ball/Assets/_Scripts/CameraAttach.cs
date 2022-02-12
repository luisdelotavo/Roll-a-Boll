using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAttach : MonoBehaviour
{
    //Variables are created
    public GameObject user;
    private Vector3 _offset;

    //Start and is used to center the camera to the object
    void Start()
    {
        _offset = transform.position - user.transform.position;
    }

    //Updates constantly to center the camera to the object
    void LateUpdate()
    {
        transform.position = user.transform.position + _offset;
    }
}
