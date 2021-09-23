using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �������ṩ�ƶ�����ת��Ѱ·
/// </summary>
public class Enemymoto : MonoBehaviour
{


    public float moveSpeed = 1f;
    public Transform[] points;
    private int currentPointIndex = 0;

    /// <summary>
    /// ��ǰ�ƶ�
    /// </summary>
    public void Movement()
    {
        this.transform.position = Vector2.MoveTowards(this.transform.position, points[currentPointIndex].position, moveSpeed * Time.deltaTime);
    }

    /// <summary>
    /// Ѱ·����·�ߣ�Vector3[]·����ɣ��ƶ�
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
        //����Ѱ·��
        //�������Ŀ�꣨�жϵ��˺�Ŀ���ļ��Vector3.Distance��
        //��ת
        //����Ŀ���
        //��ǰ�ƶ�
    }
    private void Update()
    {
        PathFinding();
    }
}