using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stage01SCR : MonoBehaviour {

    public int pointnow;
    public int maxpoint01;
    public int Num = 1;

    GameObject gryo;

    // Use this for initialization
    void Start() {
        GameData.MaxPoint = 6;
        GameData.Stage = Num;
        GameData.Point = 0;
    }

    // Update is called once per frame
    void Update() {
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