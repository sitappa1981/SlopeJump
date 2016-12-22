using UnityEngine;
using System.Collections;

public class Stage01 : MonoBehaviour {

    public int Clear;

	// Use this for initialization
	void Start () {
        GameData.Stage = Clear;
	}
	
	// Update is called once per frame
	void Update () {
        if (Clear < 1) {
            Destroy(gameObject);
        }
	}
}
