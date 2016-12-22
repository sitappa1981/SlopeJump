using UnityEngine;
using System.Collections;

public class Stage02 : MonoBehaviour {

    public int Clear;

    // Use this for initialization
    void Start() {
        GameData.Stage = Clear;
    }

    // Update is called once per frame
    void Update() {
        if (Clear < 2) {
            Destroy(gameObject);
        }
    }
}
