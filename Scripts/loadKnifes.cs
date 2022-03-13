using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadKnifes : MonoBehaviour
{
    [SerializeField] GameObject[] knifesInWood;
    [SerializeField] GameObject[] flingKnifes;

    private int _knife,_winning;
    void Start()
    {
        Time.timeScale = 1;
        _knife = PlayerPrefs.GetInt("_playingKnife");
        knifesInWood[_knife].SetActive(true);
        flingKnifes[_knife].SetActive(true);
        _winning = 0;
        PlayerPrefs.SetInt("winning", _winning);
     
    }
}
