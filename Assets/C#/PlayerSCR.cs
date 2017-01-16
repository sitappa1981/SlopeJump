using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerSCR : MonoBehaviour {

    Rigidbody2D rigid2D;

    public float jumpForce = 200.0f;    // ジャンプの飛距離
    public float walkForce = 30.0f;
    public float maxWalkSpeed = 2.0f;   // 徒歩での歩く速度
    public float threshold = 0.4f;      // 傾き度合いの判定

    public float speedx;

    public AudioClip JumpSE;

    public int pointnow;
    public int point;
    public int key = 0;

    // Use this for initialization
    void Start() {
        point = 0;

        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {

        // スペースキーを押した時にジャンプする
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            GetComponent<AudioSource>().PlayOneShot(JumpSE);
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        // 左右移動

        if (Input.GetKey(KeyCode.RightArrow)) {
            key = 1;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            key = -1;
        } else {
            key = 0;
        }

        // プレイヤーの速度(絶対値)
        speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //何もキーが押されていなければ0
        if (key == 0) {
            speedx = 0;
        }

        //最大速度
        float maxSpeed = key * this.maxWalkSpeed;
        //最大速度と現在速度の差分(絶対値)
        float diff = Mathf.Abs(maxSpeed - this.rigid2D.velocity.x);
        //現在のスピードが最高速度に近づくほどcoefficientの値は0に近づく、最大値は1
        float coefficient = Mathf.Min(diff, 1);
        //与える力 
        Vector3 addForce = transform.right * key * this.walkForce * coefficient;
        //力を与える
        this.rigid2D.AddForce(addForce);


        // 動く方向に応じて反転
        if (key != 0) {
            transform.localScale = new Vector3(key * -2, 2, 1);
        }

        // 画面外に出た場合は最初から
        if (transform.position.y < -10) {
            GameData.Point = 0;
            switch (GameData.Stage) {
                case 0:
                    SceneManager.LoadScene("_Stage00");
                    break;
                case 1:
                    SceneManager.LoadScene("_Stage01");
                    break;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.gameObject.tag == "manure") {
            GameData.Point++;
            Destroy(other.gameObject);
        }
    }
}



/*

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerSCR : MonoBehaviour {

    Rigidbody2D rigid2D;

    public float jumpForce = 200.0f;           // ジャンプの飛距離
    public float walkForce = 30.0f;            // 
    public float maxWalkSpeed = 2.0f;          // 徒歩での歩く速度
    public float threshold = 0.4f;             // 傾き度合いの判定

    public float speedx;

    public AudioClip JumpSE;

    public int pointnow;
    public int point;

    public int key = 0;


    // Use this for initialization
    void Start () {

        point = 0;

        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {

        // スペースキーを押した時にジャンプする
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            GetComponent<AudioSource>().PlayOneShot(JumpSE);
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        // 左右移動

        if (Input.GetKey(KeyCode.RightArrow)) {
            key = 1;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            key = -1;
        } else {
            key = 0;
        }

        // プレイヤーの速度
       speedx = Mathf.Abs(this.rigid2D.velocity.x);

        // スピード制限
        Vector3 a = transform.right * key * this.walkForce;

        if (key == 0) {
            speedx = 0;
        }


        if (speedx < this.maxWalkSpeed) {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
            Debug.Log("正");
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
*/
