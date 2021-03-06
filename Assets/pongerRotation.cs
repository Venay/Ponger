﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongerRotation : MonoBehaviour {

    public float rotationSpeed = 40f;
    public float dragRotationSpeed = 40f;
    int rotationDirection = 1;

	
	// Update is called once per frame
	void Update () {
        if (!Input.anyKey)
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * -rotationSpeed* rotationDirection);
            //Debug.Log(rotationDirection);

            
        } else
        {
            Debug.Log(transform.localRotation);
            Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime*dragRotationSpeed);

        }

        

        /*
        if (Input.anyKey)
        {
            float rotX = Input.GetAxis("Mouse X") * dragRotationSpeed; // * Mathf.Deg2Rad;

            transform.Rotate(Vector3.forward, -rotX);

            //Debug.Log(rotX);
            if (Input.GetAxis("Mouse X") < 0)
            {
                rotationDirection = -1;
            }
            else
            {
                rotationDirection = 1;
            }
        }
        */
    }

    /*
    private void OnMouseUp ()
    {
        rotationSpeed = rotationSpeed * (-1);
    }
    

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * dragRotationSpeed ;// * Mathf.Deg2Rad;

        transform.Rotate(Vector3.forward, -rotX);

        //Debug.Log(rotX);
        if (Input.GetAxis("Mouse X") < 0)
        {
            rotationDirection = -1;
        }
        else 
        {
            rotationDirection = 1;
        }

    }
    */
}
