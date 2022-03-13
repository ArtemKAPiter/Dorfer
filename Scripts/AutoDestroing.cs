using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroing : MonoBehaviour
{
    private float _timer;

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 2)
        {
            Destroy(gameObject);
        }
    }
}
