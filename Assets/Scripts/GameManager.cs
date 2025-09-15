using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("���� ����")]
    public int playerScore = 0;
    public int itemCollected = 0;

    [Header("UI ����")]
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
        Debug.Log($"������ ����! (�� : {itemCollected} ��");
    }
    void UpdateUI()
    {
        if(scoreText != null)
        {
            scoreText.text = "���� : " + playerScore;
        }
        if (itemCounText != null)
        {
            itemCounText.text = "������ : " + itemCollected + "��";
        }
    }
}
