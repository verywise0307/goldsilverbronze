using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하므로 잊지 않고 추가

public class GameDirector : MonoBehaviour
{
    public float maxTime = 30f; // 타이머의 최대 시간
    private float currentTime;   // 현재 타이머 시간

    public Image Image;     // 타이머 UI의 Image 컴포넌트
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
            // 타이머 UI 업데이트
            UpdateTimerUI();
        }
        // 타이머 감소


        // 타이머가 0보다 작아지면 원하는 처리 수행 (예: 게임 종료)
        else
        {
            Timer.text = "0";
            // 타이머 종료 시 수행할 동작 추가
            // 예: 게임 종료, 플레이어 사망 등
        }
    }

    private void UpdateTimerUI()
    {
        // 타이머 UI의 Fill Amount 업데이트
        float fillAmount = currentTime / maxTime;
        Image.fillAmount = fillAmount;
    }

}