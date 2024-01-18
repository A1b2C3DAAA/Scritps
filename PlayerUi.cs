using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour
{
    //Поле игрового объекта слайдер 
    public Slider healthBar;
    // поле текста с количеством монет 
    public TMPro.TextMeshProUGUI CoinsCounter;
    //Поле скрипта игрока 
    public Player player; 
    // Start is called before the first frame update
    void Start()
    {
        //Присваивание значений для ui 
        healthBar.maxValue = player.maxhealth;
        healthBar.value = player.heatlh;
        CoinsCounter.text = "coins:" + player.coin;
    }

    // Update is called once per frame
    void Update()
    {
        //Присваивание значений для ui
        healthBar.value = player.heatlh;
        CoinsCounter.text = "coins:" + player.coin;
    }
}
