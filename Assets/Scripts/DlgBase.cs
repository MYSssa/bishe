using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgBase<T> : MonoBehaviour where T : DlgBase<T>
{

    protected static T instance;

    /// <summary>
    ///继承MonoBehaviour的单例基类；做了一些特殊处理；
    ///保证场景中必须有UGUI名称的物体，所有单例管理器脚本都挂在该物体上；
    ///继承单例基类后，需要私有化构造；
    /// </summary>
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = GameObject.Find("UGUI");
                if (go == null)
                {
                    go = new GameObject("UGUI");
                    DontDestroyOnLoad(go);
                }
                instance = go.GetComponent<T>();
                if (instance == null)
                {
                    instance = go.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    void Awake()
    {

    }
    void Start()
    {

    }


    void Update()
    {

    }
}
