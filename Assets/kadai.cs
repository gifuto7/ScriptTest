using UnityEngine;
using System.Collections;

public class kadai : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        //配列の初期化
        int[] array = { 5, 9, 7, 2, 3 };

        Debug.Log("配列を順番に表示");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("配列を逆から順番に表示");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}