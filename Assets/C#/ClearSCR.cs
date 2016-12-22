using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearSCR : MonoBehaviour {

    public Button Next;
    public Text Num;

	// Use this for initialization
	void Start () {
        GameData.Point = 0;
        Num.text = "" + GameData.Stage;
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void OnNext() {
        SceneManager.LoadScene("_Stage00");
    }
}
