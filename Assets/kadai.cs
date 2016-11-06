using UnityEngine;
using System.Collections;

public class kadai : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //配列を初期化
        int[] array = { 3, 5, 7, 9, 1 };

        Debug.Log("配列の要素を表示");
        //配列を要素数の分だけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            //配列の要素を表示
            Debug.Log(array[i]);
        }

        Debug.Log("配列の要素を反対に表示");
        //配列を要素数の分だけ逆に表示
        for (int i = array.Length; i >= 0; i--)
        {
            //iと配列の要素数が等しいくない場合に実行
            if (i != array.Length)
            {
                Debug.Log(array[i]);
            }
        }
    }
}
        // Update is called once per frame
