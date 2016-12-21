using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stage00SCR : MonoBehaviour {

    public int maxpoint = 4;
    public int pointnow = 0;

    public GameObject manure;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
        Clear();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.gameObject.tag == "manure") {
            this.pointnow += 1;
            Destroy(other.gameObject);
        }
    }

    void Clear() {
        if (pointnow >= maxpoint) {
            SceneManager.LoadScene("_Clear");
        }
    }


}
