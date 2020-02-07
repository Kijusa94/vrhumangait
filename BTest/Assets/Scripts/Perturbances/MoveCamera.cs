using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    float step;
    public float speed;
    public GameObject target;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Target");
	}
	
	// Update is called once per frame
	void Update () {
        step = speed * Time.fixedDeltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.GetComponent<Transform>().position, step);
	}
}
