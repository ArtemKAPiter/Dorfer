using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    [SerializeField] Text fightText;
    [SerializeField] GameObject[] knifesValue;
    [SerializeField] GameObject bossObject,bossUI;
    private float _timer;
    private int _openknifes;
    void Start()
    {
        _openknifes = PlayerPrefs.GetInt("openknifes");
        if(_openknifes==0 || _openknifes <= 2)
        {
            _openknifes++;
            PlayerPrefs.SetInt("openknifes", _openknifes);
        }
        fightText.text = "Final Fight";
        bossUI.SetActive(true);
        for (int i = 0; i == 5; i++)
        {
            knifesValue[i].SetActive(false);
        }

    }

    void Update()
    {
        bossObject.SetActive(true);
        _timer += Time.deltaTime;
        if (_timer >= 1.2f)
        {
            bossUI.SetActive(false);
        }
      

    }
}
