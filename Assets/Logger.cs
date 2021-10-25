using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ログ用クラス
public class Logger : MonoBehaviour
{
    [SerializeField]
    NodeSample m_target = null;
    void Start()
    {
        print("===Serch Forward===");
        foreach (var next in m_target)
        {
            Debug.Log(next, next);
        }
        print("===Serch Inverse===");
        foreach (var prev in m_target.Reverse)
        {
            Debug.Log(prev, prev);
        }
    }
}
