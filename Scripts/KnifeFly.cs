using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeFly : MonoBehaviour
{
    [SerializeField] float flyingSpeed;
    [SerializeField] bool _knifeMoving;
    private int _knifesHittingValue,_winning,_myValue;
    private float score;
    [SerializeField] GameObject knifeParticles;

    int lose;
    private int _tappedValue;
    void Start()
    {
        flyingSpeed = 30f;
        _knifeMoving = false;
        Vibration.Init();
    }

    void Update()
    {
        _winning = PlayerPrefs.GetInt("winning");
        score = PlayerPrefs.GetFloat("score");
        score += Time.deltaTime * 15;
        PlayerPrefs.SetFloat("score", score);
        if (transform.position.y <= -2.5)
        {
            transform.position += new Vector3(transform.position.x,Time.deltaTime* flyingSpeed, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0)&& _winning == 0)
        {
            _knifeMoving = true;  
            Vector3 knifePos = new Vector3(0, -5, 0);
            Instantiate(gameObject, knifePos, transform.rotation);
            _tappedValue++;
            _knifesHittingValue = PlayerPrefs.GetInt("_knifesHittingValue");
            _knifesHittingValue++;
            PlayerPrefs.SetInt("_knifesHittingValue", _knifesHittingValue);
            _myValue = PlayerPrefs.GetInt("Value");
            Debug.Log(_myValue);
            _myValue++; 
            PlayerPrefs.SetInt("Value", _myValue);
        }
        if (_knifeMoving == true)
        {
            transform.position += new Vector3(transform.position.x, flyingSpeed * Time.deltaTime, transform.position.z);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wood")
        {
            Vibration.VibratePop();
            enabled = false;
            knifeParticles.transform.parent = null;
            knifeParticles.SetActive(true);
            transform.parent = other.transform;
            Vibration.VibratePop();

        }
        if (other.tag == "knife"|| other.tag == "knifeinwood")
        {
            enabled = false;
            lose = 1;
                PlayerPrefs.SetInt("lose", lose);
            Vibration.VibratePop();
            Vibration.Cancel();




        }
    }
}

