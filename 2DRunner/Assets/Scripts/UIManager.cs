using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //[SerializeField] private Slider flowerSlider;
    //[SerializeField] private Slider coinSlider;
    [SerializeField] private Image flower;
    [SerializeField] private Image coin;
    private PlayerController playerController;

    private void OnEnable()
    {
        Time.timeScale = 0;
    }
    private void Start()
    {
        playerController =FindAnyObjectByType<PlayerController>();
    }
    public static UIManager Instance { get; set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void UpdateFlowerValue(float _flowerCount)
    {
        //flowerSlider.value = _flowerCount;
        flower.fillAmount += 0.1f;
    }
    public void UpdateCoinValue(float _coinCount)
    {
        //coinSlider.value = _coinCount;
        coin.fillAmount += 0.05f;
    }
    public void UpdateFlowerIncrement(float _flowerCount)
    {
        flower.fillAmount -= 0.1f;
        if (_flowerCount <0)
        {
            Time.timeScale = 0f;
            playerController.RestartPanel.SetActive(true);
        }
    }
}
