using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("게임 상태")]
    public int playerScore = 0;
    public int itemCollected = 0;

    [Header("UI 참조")]
    public Text scoreText;
    public Text itemCounText;
    public Text gameStatusText;

    public static GameManager Instance;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void CollectItem()
    {
        itemCollected++;
        Debug.Log($"아이템 수집! (총 : {itemCollected} 개");
    }
    void UpdateUI()
    {
        if(scoreText != null)
        {
            scoreText.text = "점수 : " + playerScore;
        }
        if (itemCounText != null)
        {
            itemCounText.text = "아이템 : " + itemCollected + "개";
        }
    }
}
