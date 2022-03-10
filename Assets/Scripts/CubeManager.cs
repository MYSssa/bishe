using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{

    public GameObject cubePb;
    public Transform[] originTrans;
    public Transform[] targetTrans;
    void Start()
    {
        InvokeRepeating("creatCube", 0, 2f);
    }
    void Update()
    {

    }
    void creatCube()
    {
        int random = Random.Range(0, 2);
        GameObject obj = Instantiate(cubePb, originTrans[random].position, cubePb.transform.rotation);
        //obj.transform.DOMove(targetTrans[random].position, 5).OnComplete(delegate () {
        //    //播放完动画后销毁
        //    Destroy(obj);
        //});
        obj.transform.DOMove(targetTrans[random].position, 5).OnComplete(() =>
        {
            //播放完动画后销毁
            Destroy(obj);
        });
    }
}
