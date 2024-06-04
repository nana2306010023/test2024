using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    //�I�u�W�F�N�g�Ƃ���Player��ǉ�
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //�q�G�����L�[�ɐݒ肵�Ă���I�u�W�F�N�g����
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //�t���[�����Ƃɓ����ŗ�������
        transform.Translate(0, -0.1f, 0);

        //��ʊO�ɏo����I�u�W�F�N�g��j������
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //�����蔻���ǋL
        Vector2 p1 = transform.position;                //��̒��S���W
        Vector2 p2 = this.player.transform.position;    //�v���C���[�I�u�W�F�N�g�̒��S���W
        Vector2 dir = p1 - p2;                          //��ƃv���C���[�̋���
        float d = dir.magnitude;
        float r1 = 0.5f;                                //��̔��a
        float r2 = 1.0f;                                //�v���C���[�̔��a

        //�v���C���[�ɓ���������
        if (d < r1 + r2)
        {
            //�f�B���N�g���[�X�N���v�g�Ƀv���C���[�ƏՓ˂������Ƃ�`����
            GameObject director = GameObject.Find("GameDirector");
            //�f�B���N�g���[�X�N���v�g�̃Q�[�W�����炷���\�b�h�𓮂���
            director.GetComponent<GameDirector>().DecreaseHP();
            Destroy(gameObject);
        }



    }
}
