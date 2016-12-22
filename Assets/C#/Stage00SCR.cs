using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stage00SCR : MonoBehaviour {

    public int pointnow;
    public int maxpoint = 4;
    public int Num = 00;

    public GameObject manure;



	// Use this for initialization
	void Start () {
        GameData.Stage = Num;
    }

    // Update is called once per frame
    void Update () {
        pointnow = GameData.Point;
        Clear();
    }

    void Clear() {
        pointnow = GameData.Point;
        if (pointnow >= maxpoint) {
            SceneManager.LoadScene("_Clear");
        }
    }
}