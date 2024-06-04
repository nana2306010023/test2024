using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //オブジェクトとしてPlayerを追加
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //ヒエラルキーに設定しているオブジェクトを代入
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに等速で落下する
        transform.Translate(0, -0.1f, 0);

        //画面外に出たらオブジェクトを破棄する
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //当たり判定を追記
        Vector2 p1 = transform.position;                //矢の中心座標
        Vector2 p2 = this.player.transform.position;    //プレイヤーオブジェクトの中心座標
        Vector2 dir = p1 - p2;                          //矢とプレイヤーの距離
        float d = dir.magnitude;
        float r1 = 0.5f;                                //矢の半径
        float r2 = 1.0f;                                //プレイヤーの半径

        //プレイヤーに当たったら
        if (d < r1 + r2)
        {
            //ディレクトリースクリプトにプレイヤーと衝突したことを伝える
            GameObject director = GameObject.Find("GameDirector");
            //ディレクトリースクリプトのゲージを減らすメソッドを動かす
            director.GetComponent<GameDirector>().DecreaseHP();
            Destroy(gameObject);
        }



    }
}
