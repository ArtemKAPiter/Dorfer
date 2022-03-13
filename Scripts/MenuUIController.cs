using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIController : MonoBehaviour
{
    [SerializeField] GameObject play, settings,stats;
    [SerializeField] Slider wheelSpeed;
    [SerializeField] Text wheelSpeedText,myRecord,myValue;
    [SerializeField] Button[] myKnifes;
    private int _openKnifes,_playingKnife;
    [SerializeField] GameObject settingsPanel;
    [SerializeField] GameObject records;
    private float _myRecord,_wheelSpeed;
    private int _myValue;
    [SerializeField] Image[] myKnife;

    void Start()
    {

        _myRecord = PlayerPrefs.GetFloat("Record");
        myRecord.text ="Your record: " + _myRecord.ToString("F0");
        _myValue = PlayerPrefs.GetInt("Value");
            myValue.text = "Your value: " + _myValue.ToString();
        _openKnifes = PlayerPrefs.GetInt("openknifes");
        Debug.Log(_openKnifes);
        for(int i = 0; i <= _openKnifes; i++)
        {
            myKnifes[i].interactable = true;
        }
        _wheelSpeed = PlayerPrefs.GetFloat("WheelSpeed");
        wheelSpeed.value = _wheelSpeed;
        
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
        Vibration.VibratePop();
    }
    public void Settings()
    {
       
        play.SetActive(false);
        settings.SetActive(false);
        stats.SetActive(false);
        settingsPanel.SetActive(true);
        Vibration.VibratePop();
    }
    public void Stats()
    {
        records.SetActive(true);
        stats.SetActive(false);
        settings.SetActive(false);
        play.SetActive(false);
    }
    public void FirstKnife()
    {
        _playingKnife = 0;
        PlayerPrefs.SetInt("_playingKnife", _playingKnife);
        knifesColorWhite();
        myKnife[0].GetComponent<Image>().color = new Color32(190, 124, 255, 149);
    }
    public void Secondknife()
    {
        _playingKnife = 1;
        PlayerPrefs.SetInt("_playingKnife", _playingKnife);
        knifesColorWhite();
        myKnife[1].GetComponent<Image>().color = new Color32(190, 124, 255, 149);
    }
    public void ThreeKnife()
    {
        _playingKnife = 2;
        PlayerPrefs.SetInt("_playingKnife", _playingKnife);
        knifesColorWhite();
        myKnife[2].GetComponent<Image>().color = new Color32(190, 124, 255, 149);

    }
    public void FourKnife()
    {
        _playingKnife = 3;
        PlayerPrefs.SetInt("_playingKnife", _playingKnife);
        knifesColorWhite();
        myKnife[3].GetComponent<Image>().color = new Color32(190, 124, 255, 149);

    }

    void Update()
    {
        wheelSpeedText.text = "Wheel rotation speed " + (20*wheelSpeed.value).ToString("F0")+"%";
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            settingsPanel.SetActive(false);
            records.SetActive(false);
            stats.SetActive(true);
            settings.SetActive(true);
            play.SetActive(true);
        }
        _wheelSpeed = wheelSpeed.value;
        PlayerPrefs.SetFloat("WheelSpeed", _wheelSpeed);

       


    }
    void knifesColorWhite()
    {
        for(int i = 0; i <= 3; i++)
        {
            myKnife[i].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }

}

