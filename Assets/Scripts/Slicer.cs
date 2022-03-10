using EzySlice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    public Material sliceSurface;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //省略
        Collider[] colliders = Physics.OverlapBox(transform.position, transform.localScale / 2, transform.rotation, LayerMask.GetMask("Slice"));
        if (colliders.Length > 0)
        {
            foreach (var collider in colliders)
            {
                Destroy(collider.gameObject);
                //位置与法线获得切割面
                SlicedHull hull = collider.gameObject.Slice(transform.position, transform.up);
                if (hull != null)
                {
                    GameObject upper = hull.CreateLowerHull(collider.gameObject, sliceSurface);
                    GameObject lower = hull.CreateUpperHull(collider.gameObject, sliceSurface);
                    GameObject[] objs = new GameObject[] { upper, lower };

                    foreach (var obj in objs)
                    {
                        //添加刚体并设为凸多面体
                        obj.gameObject.AddComponent<Rigidbody>();
                        obj.gameObject.AddComponent<MeshCollider>().convex = true;
                    }
                    //施加力
                    objs[0].gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 100);
                    objs[1].gameObject.GetComponent<Rigidbody>().AddForce(-transform.up * 100);
                }
            }
        }



    }
}
