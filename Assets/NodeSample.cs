using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//順方向、逆方向への参照を持つノードクラス
public class NodeSample : MonoBehaviour, IEnumerable<NodeSample>
{
    //次のノード
    [SerializeField] private NodeSample m_next = null;

    //前のノード
    [SerializeField] private NodeSample m_prev = null;

    //IEnumerable<NodeSample>の実装　ここでは、順方向にノードを返す。
    public IEnumerator<NodeSample> GetEnumerator()
    {
        yield return this;
        if (this.m_next == null) yield break;
        foreach(var next in this.m_next){
            yield return next;
        }
    }

    //IEnumerable<NodeSample>の実装
    // !ここはGetEnumerator()を返す以外の適当な実装を知らないので、何かあれば教えてください
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    //逆向きにノードを返す。
    public IEnumerable<NodeSample> Reverse
    {
        get
        {
            yield return this;
            if (this.m_prev == null) yield break;
            foreach (var node in this.m_prev.Reverse)
            {
                yield return node;
            }
        }
    }
}
