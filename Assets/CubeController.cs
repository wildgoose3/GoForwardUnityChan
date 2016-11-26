using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{        
    //効果音再生のため追加
    private AudioSource Sound1;

    //キューブの移動速度
    private float speed = -0.2f;

    //消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {
        //効果音再生のため追加
        this.Sound1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //接触したら実行
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag")//CubeかGroundならば
        {
            Sound1.PlayOneShot(Sound1.clip);
        }
    }
}
