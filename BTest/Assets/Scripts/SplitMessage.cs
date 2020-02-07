using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplitMessage : MonoBehaviour
{
    public Text msg;
    public Text speedText;
    public Text perturbanceText;

    public char[] delimiterChars1 = { ',' };
    public char[] delimiterChars2 = { ';' };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string[] words = msg.text.Split(delimiterChars2, System.StringSplitOptions.RemoveEmptyEntries);
        string[] words2 = words[0].Split(delimiterChars1, System.StringSplitOptions.RemoveEmptyEntries);
        speedText.text = words2[0];
        perturbanceText.text = words[1];
    }
}
