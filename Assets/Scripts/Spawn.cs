using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject spawn;
    public GameObject spawner;
    public float time = 10;
    GameObject spawnClone;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        time -= Time.deltaTime;

        if (time <= 0)
        {
            spawnClone = Instantiate(spawn, spawner.transform.position, spawner.transform.rotation) as GameObject;
            time = 10;
        }

	}
}
