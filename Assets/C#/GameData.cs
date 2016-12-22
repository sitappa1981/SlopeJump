using System.Collections;

public class GameData {

    private static GameData instance = new GameData();
    private GameData(){}

    //**********
    // 変数定義
    //**********

    public int point = 0;   // 獲得した点数
    public int stage = 0;   // 現在のステージ
    
    public static int Point {
        get { return instance.point; } 
        set { instance.point = value; }
    }

    public static int Stage {
        get { return instance.stage; }
        set { instance.stage = value; }
    }

}
