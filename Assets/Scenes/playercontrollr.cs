using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //FPS60��ݒ�
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //���L�[�����������獶�Ɉړ�
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //transform.Translate(-3, 0, 0);
        }
        //�E�L�[������������E�Ɉړ�
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //transform.Translate(3, 0, 0);
        }

        //�Q�[���I�[�o�[�Ȃ�v���C���[������
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
