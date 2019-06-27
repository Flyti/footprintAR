using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour {

    public Transform transform1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExChange() {
        
        transform.position = transform1.position;
        transform.rotation = transform1.rotation;
        transform.localScale = transform1.localScale;
    }
    
}
