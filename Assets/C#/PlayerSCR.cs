using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerSCR : MonoBehaviour {

    Rigidbody2D rigid2D;

    float jumpForce = 400.0f;           // ジャンプの飛距離
    float walkForce = 30.0f;            // 
    float maxWalkSpeed = 2.0f;          // 徒歩での歩く速度
    float threshold = 0.2f;             // 傾き度合いの判定

    public AudioClip JumpSE;

    public int pointnow;
    public int point;

    // Use this for initialization
    void Start () {

        point = 0;

        this.rigid2D = GetComponent<Rigidbody2D>();
//        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update () {

        // スペースキーを押した時にジャンプする
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            GetComponent<AudioSource>().PlayOneShot(JumpSE);
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        // 左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow) || Input.acceleration.x > this.threshold) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.acceleration.x < this.threshold) key =  -1;

        // プレイヤーの速度
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // スピード制限
        if (speedx < this.maxWalkSpeed) {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);

        }
        // 動く方向に応じて反転
        if (key != 0) {
            transform.localScale = new Vector3( key*-2, 2, 1);
        }

        // 画面外に出た場合は最初から
        if (transform.position.y < -10) {
            GameData.Point = 0;
            SceneManager.LoadScene("_Stage00");
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.gameObject.tag == "manure") {
            GameData.Point++;
            Destroy(other.gameObject);
        }
    }
}
