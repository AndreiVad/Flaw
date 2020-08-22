using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraChange : MonoBehaviour {
    public Camera cam1;
    public Camera cam2;
    public float time = 10;
	// Use this for initialization
	void Start () {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    // Update is called once per frame
    void Update() {

        if (time <=0) {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        time = time - Time.deltaTime;
    }
}

 