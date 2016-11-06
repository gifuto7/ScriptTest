using UnityEngine;
using System.Collections;

public class hattenn : MonoBehaviour
{

    //変数初期化
    private int hp = 100;   //体力
    private int power = 25; //攻撃力
    int mp = 53;    //マジックポイント
    string mozi = "魔法攻撃をした。残りMPは"; 
    string mozi2 = "。";

    //魔法攻撃用関数
    public void Magic(int cons)
    {
        //MPが足りなくなるまで魔法を使い続ける。
        for (int i = mp; i >= cons; i -= cons)
        {
            //いくらMPを消費したか表示
            Debug.Log(mozi + i.ToString() + mozi2);
        }
        //MPがなくなると表示
        Debug.Log("MPが足りないため魔法が使えない");
    }
    //攻撃用関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpをへらす
        this.hp -= damage;
    }
    void Start()
    {

        //魔法用の関数を呼び出す
        Magic(5);
        // 攻撃用の関数を呼び出す
        Attack();
        // 防御用の関数を呼び出す
        Defence(3);
    }

    void Update()
    {

    }






}


 




