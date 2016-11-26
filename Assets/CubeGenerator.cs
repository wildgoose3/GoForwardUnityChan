using UnityEngine;
using System.Collections;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    private float delta = 0;
    private float span = 1.0f;
    private float genPosX = 12;
    private float offsetY = 0.3f;
    private float spaceY = 6.9f;
    private float offsetX = 0.5f;
    private float spaceX = 0.4f;
    private int maxBlockNum = 4;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        //span秒以上の時間が経過したかを調べる
        if (this.delta > this.span)
        {
            this.delta = 0;
            //生成するキューブ数をランダムに決める
            int n = Random.Range(1, maxBlockNum + 1);

            //指定した数だけキューブを生成する
            for (int i = 0; i < n; i++)
            {
                GameObject go = Instantiate(cubePrefab) as GameObject;
                go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
            }

            //次のキューブまでの生成時間を決める
            this.span = this.offsetX + this.spaceX * n;
        }
    }
}
