using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stage00SCR : MonoBehaviour {

    public int pointnow;
    public int maxpoint = 4;
    public int Num = 00;

    GameObject gryo;

	// Use this for initialization
	void Start () {
        GameData.Stage = Num;
        this.gryo = GameObject.Find("gyro");
    }

    // Update is called once per frame
    void Update () {
        this.gryo.GetComponent<Text>().text = Input.acceleration.ToString();
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