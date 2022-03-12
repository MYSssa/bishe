using EzySlice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform lastPos;
    public Transform slicePoint;
    public Material sliceSurface;

    void Start()
    {

        setAllowDir();
    }

    void Update()
    {
        //setMoveDir();
    }

    /// <summary>
    /// 设置物体的箭头方向
    /// </summary>
    void setAllowDir()
    {
        int allowDir = Random.Range(1, 5);
        transform.Rotate(new Vector3(90 * allowDir, transform.rotation.y, transform.rotation.z));
    }

    public void slice()
    {
        //位置与法线获得切割面
        SlicedHull hull = gameObject.Slice(slicePoint.position, slicePoint.right);
        if (hull != null)
        {
            GameObject upper = hull.CreateLowerHull(gameObject, sliceSurface);
            GameObject lower = hull.CreateUpperHull(gameObject, sliceSurface);
            GameObject[] objs = new GameObject[] { upper, lower };
            foreach (var obj in objs)
            {
                //添加刚体并设为凸多面体
                obj.gameObject.AddComponent<Rigidbody>();
                obj.gameObject.AddComponent<MeshCollider>().convex = true;
            }
        }
        Destroy(gameObject);
    }

    /// <summary>
    /// 给方块的限定方向（没想好怎么使用）
    /// </summary>
    void setMoveDir()
    {
        int moveDir = 0;
        Vector3 dir = transform.position - lastPos.position;
        //分别是 左移 下移 右移 上移
        if (dir.x < 0)
        {
            moveDir = 1;
        }
        if (dir.y < 0)
        {
            moveDir = 2;
        }
        if (dir.x > 0)
        {
            moveDir = 3;
        }
        if (dir.y > 0)
        {
            moveDir = 4;
        }
    }
}
