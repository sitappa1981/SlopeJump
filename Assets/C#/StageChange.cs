using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class StageChange : MonoBehaviour {

    public Button GameOverButton;
    public Button TitleButton;
    public Button RetryButton;

    public static int StageNo = 1;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // ゲームプレイ画面でゲームオーバーボタンを押した場合
    public void GameOver() {
        SceneManager.LoadScene("_GameOver");
    }

    // ゲームオーバー画面でタイトルを押した場合
    public void LordTitle() {
        SceneManager.LoadScene("_Start");
    }
    // ゲームオーバー画面でリトライを押した場合
    public void LordRetry() {
        SceneManager.LoadScene("_Stage00");
    }
}
