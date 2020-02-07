using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePerturbance : MonoBehaviour {

    public float frecuency;
    public float Amp;

    public bool StartPerturbance;

    public float t = 0;

    public float SinOffset = 0f;

    float posx;
    float posy;
    float posz;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        t += 1;
        if (StartPerturbance)
        {
            gameObject.GetComponent<Transform>().position = new Vector3(0, 0, (Amp * Mathf.Sin(frecuency * Mathf.PI * 2 * t) + SinOffset));
            //Debug.Log(Time.fixedTime);
        }
    }
}
