using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJLookatCamara : MonoBehaviour {

    public Transform camara;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (camara != null) {

            this.transform.LookAt(camara);
            transform.Rotate(offset);
        }

	}
}
