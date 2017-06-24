using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlane : MonoBehaviour {

    public GameObject plane;
    float v, h;
	// Update is called once per frame
	void Update () {
        v = Input.GetAxis("Vertical") * 0.1f;
        h = Input.GetAxis("Horizontal") * 0.25f;
        plane.transform.position = new Vector3(plane.transform.position.x, plane.transform.position.y + v, plane.transform.position.z);
        plane.transform.eulerAngles = new Vector3(plane.transform.eulerAngles.x, plane.transform.eulerAngles.y, plane.transform.eulerAngles.z + h);

	}
}
