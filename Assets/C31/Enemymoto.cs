using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 敌人马达：提供移动，旋转，寻路
/// </summary>
public class Enemymoto : MonoBehaviour
{


    public float moveSpeed = 1f;
    public Transform[] points;
    private int currentPointIndex = 0;

    /// <summary>
    /// 向前移动
    /// </summary>
    public void Movement()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, points[currentPointIndex].position, moveSpeed * Time.deltaTime);
    }

    /// <summary>
    /// 寻路，沿路线（Vector3[]路点组成）移动
    /// </summary>
    /// <returns></returns>
    public void PathFinding()
    {


        Movement();
        float distance = Vector3.Distance(this.transform.position, points[currentPointIndex].position);
        if (distance < 0.1f)
        {
            currentPointIndex++;
        }

        if (currentPointIndex >= points.Length)
        {
            currentPointIndex = 0;
        }
        //继续寻路。
        //如果到达目标（判断敌人和目标点的间距Vector3.Distance）
        //旋转
        //更新目标点
        //向前移动
    }
    private void Update()
    {
        PathFinding();
    }
}