﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerSCR : MonoBehaviour {

    Rigidbody2D rigid2D;

    float jumpForce = 400.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;

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
        if (Input.GetKeyDown(KeyCode.Space)) {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        // 左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key =  -1;

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
