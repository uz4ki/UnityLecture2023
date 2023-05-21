using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ex_CoinUI : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public Ex_GameManager exGameManager;


    void Update()
    {
        textMeshProUGUI.text = "Coins:" + exGameManager.coinNum;
    }
}
