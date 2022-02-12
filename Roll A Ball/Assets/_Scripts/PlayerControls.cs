using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is used for user-inputted movement
public class PlayerControls : MonoBehaviour
{
    //Creating Vector3 variables
    [SerializeField]
    Vector3 changeOfSpeed;

    [SerializeField]
    KeyCode upMovement;
    [SerializeField]
    KeyCode downMovement;

    //For every FixedUpdate, the velocity of the game ball changes
    void FixedUpdate ()
    {
        if (Input.GetKey(upMovement))
            GetComponent<Rigidbody>().velocity += changeOfSpeed;

        if (Input.GetKey(downMovement))
            GetComponent<Rigidbody>().velocity -= changeOfSpeed;
    }
}