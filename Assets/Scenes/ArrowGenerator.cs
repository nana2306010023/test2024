using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    //prefab�Ɏg���I�u�W�F�N�g�𐶐�
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //�Q�[���I�[�o�[�t���O���m�F
        if (GameObject.Find("GameDirector").GetComponent<GameDirector>().IsGameOver())
        {
            Destroy(this);
            return;
        }
        //delta�Ɍo�ߎ��Ԃ�ǉ�
        this.delta += Time.deltaTime;
        //�P�b�o�߂�����A��𐶐�����
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);

        }

    }
}
