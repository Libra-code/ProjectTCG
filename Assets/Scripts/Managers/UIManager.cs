﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;


public class UIManager : MonoBehaviour
{
    #region Singleton
    private static UIManager instance = null;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<UIManager>();
            }
            return instance;
        }
    }
    #endregion

    public TextMeshProUGUI PlayerMana { get => playerMana; set => playerMana = value; }
    public GameObject LevelPanel { get => levelPanel; set => levelPanel = value; }
    public GameObject FadeLevelPanel { get => fadeLevelPanel; set => fadeLevelPanel = value; }


    [SerializeField] Slider playerHpSlider;
    [SerializeField] Slider enemyHpSlider;
    [SerializeField] TextMeshProUGUI playerMana;

    [SerializeField] GameObject levelPanel;
    [SerializeField] GameObject fadeLevelPanel;

    // Start is called before the first frame update

    public void UpdateEnemyHP(Enemy target)
    {
        enemyHpSlider.value = target.CurrHealth / target.MaxHealth;
    }

    public void FadeInLevelPanel()
    {
        fadeLevelPanel.SetActive(true);
        Invoke("ShowLevelPanel", 1.5f);
    }

    void ShowLevelPanel()
    {
        levelPanel.SetActive(true);
        //fadeLevelPanel.SetActive(false);
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}