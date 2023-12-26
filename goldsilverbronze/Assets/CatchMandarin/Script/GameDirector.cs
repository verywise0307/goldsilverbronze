using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI�� ����ϹǷ� ���� �ʰ� �߰�

public class GameDirector : MonoBehaviour
{
    public float maxTime = 30f; // Ÿ�̸��� �ִ� �ð�
    private float currentTime;   // ���� Ÿ�̸� �ð�

    public Image Image;     // Ÿ�̸� UI�� Image ������Ʈ
    public Text Timer;


    private void Start()
    {
        currentTime = maxTime;
    }

    private void Update()
    {
        if (currentTime >= 0f)
        {
            currentTime -= Time.deltaTime;


            Timer.text = Mathf.Floor(currentTime).ToString();
            // Ÿ�̸� UI ������Ʈ
            UpdateTimerUI();
        }
        // Ÿ�̸� ����


        // Ÿ�̸Ӱ� 0���� �۾����� ���ϴ� ó�� ���� (��: ���� ����)
        else
        {
            Timer.text = "0";
            // Ÿ�̸� ���� �� ������ ���� �߰�
            // ��: ���� ����, �÷��̾� ��� ��
        }
    }

    private void UpdateTimerUI()
    {
        // Ÿ�̸� UI�� Fill Amount ������Ʈ
        float fillAmount = currentTime / maxTime;
        Image.fillAmount = fillAmount;
    }

}