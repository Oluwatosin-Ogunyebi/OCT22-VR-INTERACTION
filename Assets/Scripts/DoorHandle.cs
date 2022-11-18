using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandle : MonoBehaviour
{
    public Transform doorHandleGrabTarget;
    public Rigidbody fixedJointDoor_Rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Method TIme: " + Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate Method TIme: " + Time.deltaTime);
        fixedJointDoor_Rb.MovePosition(doorHandleGrabTarget.position);
    }

    public void ReleaseHandle()
    {
        doorHandleGrabTarget.position = transform.position;
        doorHandleGrabTarget.rotation = transform.rotation;
        fixedJointDoor_Rb.velocity = Vector3.zero;
        fixedJointDoor_Rb.angularVelocity = Vector3.zero;
    }
}
