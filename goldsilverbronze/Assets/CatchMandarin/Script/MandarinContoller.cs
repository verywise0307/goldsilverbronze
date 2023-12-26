using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    GameObject director;

    void Start()
    {
        this.player = GameObject.Find("player");
        this.director = GameObject.Find("NumberDirector");
    }

    void Update()
    {
        // �����Ӹ��� ������� ���Ͻ�Ų�� 
        transform.Translate(0, -0.01f, 0);

        // ȭ�� ������ ������ ������Ʈ�� �Ҹ��Ų��
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // �浹 ����
        Vector2 p1 = transform.position;              // ȭ���� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;  // �÷��̾��� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  // ȭ���� �ݰ�
        float r2 = 1.0f;  // �÷��̾��� �ݰ�

        if (d < r1 + r2 && p1.y >= -2)
        {
            // �浹�� ���� ȭ���� �����
            Destroy(gameObject);
            this.director.GetComponent<NumberDirector>().GetMandarin();
        }
    }
}