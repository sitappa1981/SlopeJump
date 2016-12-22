using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stage00SCR : MonoBehaviour {

    public int pointnow = 0;
    public int maxpoint = 4;

    public GameObject manure;



	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
        
        Clear();
    }

    void Clear() {
        pointnow = PlayerSCR.point;
        if (pointnow >= maxpoint) {
            pointnow = 0 ;
            SceneManager.LoadScene("_Clear");
        }
    }


}
