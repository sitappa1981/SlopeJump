using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearSCR : MonoBehaviour {

    public Button Next;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

	}

    public void OnNext() {
        SceneManager.LoadScene("_Stage00");
    }

}
