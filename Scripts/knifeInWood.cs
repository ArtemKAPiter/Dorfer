using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeInWood : MonoBehaviour
{    [SerializeField] GameObject[] knifeOnWood;
    private int _knifesValue;

    void Start()
    {
        for (int k = 0; k <= (_knifesValue = Random.Range(0, 3)); k++)
        {
            knifeOnWood[k].SetActive(true);
        }
    }

}
