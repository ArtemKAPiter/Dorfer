using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restartGame : MonoBehaviour
{
    public GameObject panelOfLose, newSkinText;
    protected int _lose,_value,_myvalue;
    protected float _progress;
    [SerializeField] Text progressText, progressText1,currentScore,currentValue,currentValueLose,currentValueWinning;
    private int _myValue,_winning, _openknifes;
    private float _record;


    void Start()
    {
   

        _progress = 0;
        PlayerPrefs.SetFloat("_knifesHittingValue", _progress);
        Time.timeScale = 1;
        _lose = 0;
        PlayerPrefs.SetInt("lose", _lose);
        _winning = 0;
        PlayerPrefs.SetInt("winning", _winning);

    }

    public void Update()
    {

        _progress = PlayerPrefs.GetFloat("score");
        currentScore.text = "00"+_progress.ToString("F0");
        _value = PlayerPrefs.GetInt("_knifesHittingValue");
        
        currentValue.text = _value.ToString();
        progressText1.text = "Your Score: " + _progress.ToString("F0");
        currentValueWinning.text = "Your value: " + _value.ToString();
        _openknifes = PlayerPrefs.GetInt("openknifes");
        if (_openknifes <= 2)
        {
            newSkinText.SetActive(true);
        }
        _lose = PlayerPrefs.GetInt("lose");
        if (_lose == 1)
        {
            panelOfLose.SetActive(true);
            progressText.text = "Your Score: " + _progress.ToString("F0");
           currentValueLose.text = "Value: " + _value.ToString();

           
            _record = PlayerPrefs.GetFloat("Record");
            if (_progress > _record)
            {
                _record = _progress;
                PlayerPrefs.SetFloat("Record", _record);
            }
            enabled = false;  
            }
        
    }
    public void Restart()
    {
        _progress = 0;
        PlayerPrefs.SetFloat("_knifesHittingValue", _progress);
        _value = 0;
        PlayerPrefs.SetInt("score", _value);
        Time.timeScale = 1;
        _lose = 0;
        PlayerPrefs.SetInt("lose", _lose);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        _winning = 0;
        PlayerPrefs.SetInt("winning", _winning);
   



    }
    public void Menu()
    {
        
        SceneManager.LoadScene(0);
    }
    public void ShowLoseMenu()
    {
        panelOfLose.SetActive(true);
    }
}
