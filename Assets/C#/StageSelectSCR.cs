using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StageSelectSCR : MonoBehaviour {

    //    public int[] Num = new int[10];
    public Button[] StageNum = new Button[10];
    public Button TitleButton;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Title() {
        SceneManager.LoadScene("_Start");
    }
    
    public void Stage00(){
        SceneManager.LoadScene("_Stage00");
    }

    public void Stage01() {
        SceneManager.LoadScene("_Stage01");
    }
    public void Stage02() {

    }





}
