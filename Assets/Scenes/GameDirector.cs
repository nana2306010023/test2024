using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        //HPゲージをオブジェクトに追加
        this.hpGauge = GameObject.Find("hpGauge");
        gameover.SetActive(false);
    }

    private void Update()
    {
        if (IsGameOver())
        {
            this.gameover.SetActive(true);
        }
    }
    //ゲームオーバーメソッド

    public bool IsGameOver()
    {
        if (hpGauge.GetComponent<Image>().fillAmount <= 0.0f)
        {
            return true;
        }
        return false;
    }
    public void DecreaseHP()
    {
        //当たり判定があったら、HPゲージを0.1ずつ減らす（消す）
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

}
