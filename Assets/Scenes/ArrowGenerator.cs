using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    //prefabに使うオブジェクトを生成
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //ゲームオーバーフラグを確認
        if (GameObject.Find("GameDirector").GetComponent<GameDirector>().IsGameOver())
        {
            Destroy(this);
            return;
        }
        //deltaに経過時間を追加
        this.delta += Time.deltaTime;
        //１秒経過したら、矢を生成する
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);

        }

    }
}
