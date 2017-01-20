using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stage00SCR : MonoBehaviour {

    public int pointnow;
    public int maxpoint00;
    public int Num = 0;

    GameObject gryo;


	// Use this for initialization
	void Start () {
        GameData.MaxPoint = 4;
        GameData.Stage = Num;
        this.gryo = GameObject.Find("gyro");
    }

    // Update is called once per frame
    void Update () {
        pointnow = GameData.Point;
        Clear();
    }

    void Clear() {
        pointnow = GameData.Point;
        if (pointnow >= GameData.MaxPoint) {
            SceneManager.LoadScene("_Clear");
        }
    }
}