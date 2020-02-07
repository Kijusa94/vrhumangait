using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Perturbance : MonoBehaviour {

    private float frecuency = 0;
    private float Amp = 0;
    private int StartPerturbance = 0;
    private float t = 0;
    private float SinOffset = 0f;

    public Text PerturbanceMsg;
    private char[] delimiterChars = { ',',';' };

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        string StrPerturbance = PerturbanceMsg.text;

        string[] words = StrPerturbance.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);

        StartPerturbance = Convert.ToInt16(words[0], CultureInfo.CreateSpecificCulture("en-US"));
        
        Amp = Convert.ToSingle(words[1], CultureInfo.CreateSpecificCulture("en-US"));
        
        frecuency = Convert.ToSingle(words[2], CultureInfo.CreateSpecificCulture("en-US"));
        t += 1;
        if (StartPerturbance == 1)
        {
            gameObject.GetComponent<Transform>().Rotate(new Vector3(0, Amp*Mathf.Sin(frecuency*Mathf.PI*2*t) + SinOffset,0));
            //Debug.Log(Time.fixedTime);
        }
    }
}
