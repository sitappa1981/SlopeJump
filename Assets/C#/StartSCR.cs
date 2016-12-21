using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class StartSCR : MonoBehaviour {

    public Button start;
    public Button Lord;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void OnStart() {
        Debug.Log("Start");
        SceneManager.LoadScene("_Stage00");
    }

    public void OnLord() {
        Debug.Log("Lord");
        SceneManager.LoadScene("_StageSelect");
    }

}
