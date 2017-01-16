using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearSCR : MonoBehaviour {

    public Button Next;
    public Text Num;
    public int NextStage;

	// Use this for initialization
	void Start () {
        GameData.Point = 0;
        Num.text = "" + GameData.Stage;
        NextStage = GameData.Stage + 1;
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void OnNext() {
        switch (NextStage) {
            case 1:
                SceneManager.LoadScene("_Stage01");
                break;
        }
    }
}
