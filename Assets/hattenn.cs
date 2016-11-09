using UnityEngine;
using System.Collections;

public class hattenn : MonoBehaviour
{

    public int hp = 100;
    public int power = 25;
    int mp = 53;
    string mozi = "魔法攻撃をした。残りMPは";
    string mozi2 = "。";
    string mozi3 = "MPが足りまいため魔法が使えない";

    //魔法用関数で真偽値格納
    public bool Magic(int cons)
    {
        //魔法を使うためのMPが足りるかを判定
        if (mp >= cons)
        {
            //足りたためwhileにtrueを返す。

            return true;
        }
        else
        {
           //足りなかったためwhileにfalseを返す。
            return false;
        }
    }

    //攻撃用関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用関数
    public void Defence(int damage)
    {
        Debug.Log(this.power + "のダメージを与えた");
        //残りhpを減らす
        this.hp -= damage;
    }

    void Start()
    {
        int mpcons = 5;

        //falseが返されるまでステートメンのブロックを毎度実行
        while (Magic(mpcons))
        {
            //MPから消費分の数値を引く
            mp -= mpcons;

            Debug.Log(mozi + mp.ToString() + mozi2);
        }
        //whileから抜けると表示
        Debug.Log("MPが足りないため魔法が使えない。");
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


 



