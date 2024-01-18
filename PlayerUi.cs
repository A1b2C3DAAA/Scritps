using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    //���� �������� ������� ������� 
    public Slider healthBar;
    // ���� ������ � ����������� ����� 
    public TMPro.TextMeshProUGUI CoinsCounter;
    //���� ������� ������ 
    public Player player; 
    // Start is called before the first frame update
    void Start()
    {
        //������������ �������� ��� ui 
        healthBar.maxValue = player.maxhealth;
        healthBar.value = player.heatlh;
        CoinsCounter.text = "coins:" + player.coin;
    }

    // Update is called once per frame
    void Update()
    {
        //������������ �������� ��� ui
        healthBar.value = player.heatlh;
        CoinsCounter.text = "coins:" + player.coin;
    }
}
