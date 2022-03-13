using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeHitting : MonoBehaviour
{

    private int tappingValue=-1;
    [SerializeField] Image[] knifesValue;
    [SerializeField] GameObject particle,cylinder,secondwood,apple;
    [SerializeField] CylinderRotation script;
    [SerializeField] KnifeFly script1;
    [SerializeField] Material white, originalColor;
    [SerializeField] Image indicator;

    private float _timer;
    private int _knifesValue;

    void Start()
    {
        
        appleChance rand = new appleChance();
        if (rand.random == 0)
        {
            apple.SetActive(true);
        }
        else
        {
            apple.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "knife")
        {
            tappingValue++;
            knifesValue[tappingValue].GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }
    void Update()
    {


        if (tappingValue >= 9)
        {       
            tappingValue = -1;
            particle.SetActive(true);
            script.enabled = false;
            secondwood.SetActive(true);
            enabled = false;
            gameObject.SetActive(false);
            cylinder.SetActive(false);
            indicator.GetComponent<Image>().color = new Color32(6, 255, 0, 255);
            for (int i = 0; i <= 9; i++)
            {
                knifesValue[i].GetComponent<Image>().color = new Color32(253, 0, 199, 255);
               
            }
           
            
        }
    }
    
}
