using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossCompleted : MonoBehaviour
{
    [SerializeField] GameObject Final;
    private float _timer;
    private int _winning;
    private int _openknifes;
    [SerializeField] Text newSkinText;

    void Start()
    {
        Final.SetActive(true);
      
    }
    void Update()
    {

        _timer += Time.deltaTime;
        _winning = 1;
        PlayerPrefs.SetInt("winning", _winning);
        if (_timer >= 1.2f) {
                Vibration.VibratePop();
            Time.timeScale = 0;
            enabled = false;
        }
    }

}
