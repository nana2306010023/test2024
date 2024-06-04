using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //FPS60を設定
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //左キーを押下したら左に移動
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //transform.Translate(-3, 0, 0);
        }
        //右キーを押下したら右に移動
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //transform.Translate(3, 0, 0);
        }

        //ゲームオーバーならプレイヤーを消す
        if (GameObject.Find("GameDirector").GetComponent<GameDirector>().IsGameOver())
        {
            Destroy(gameObject);
        }
    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDoen()
    {
        transform.Translate(3, 0, 0);
    }
}
