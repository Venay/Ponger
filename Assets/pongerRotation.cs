using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongerRotation : MonoBehaviour {

    public float rotationSpeed = 40f;

	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
	}

    private void OnMouseUp ()
    {
        rotationSpeed = rotationSpeed * (-1);
    }
}
