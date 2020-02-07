using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    //public GameObject BTConfig;
    //public GameObject BTMenu;
    private IEnumerator coroutine;

    // Use this for initialization
    void Start () {
        coroutine = OnClickChangeScene(1);
        StartCoroutine(coroutine);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator OnClickChangeScene(int scene)
    {
        yield return new WaitForSeconds(30);
        //BTMenu.GetComponent<Transform>().position = new Vector3(1000, 0, 0);
        //DontDestroyOnLoad(BTConfig);
        //DontDestroyOnLoad(BTMenu);
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
