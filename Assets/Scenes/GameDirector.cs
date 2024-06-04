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
        //HP�Q�[�W���I�u�W�F�N�g�ɒǉ�
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
    //�Q�[���I�[�o�[���\�b�h

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
        //�����蔻�肪��������AHP�Q�[�W��0.1�����炷�i�����j
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

}
