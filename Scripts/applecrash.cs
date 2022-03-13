using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applecrash : MonoBehaviour
{
    [SerializeField] GameObject appleParticle;
    protected float _currentScore;
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "knife")
        {
            appleParticle.SetActive(true);
            gameObject.SetActive(false);
            appleParticle.transform.parent = null;
            _currentScore = PlayerPrefs.GetFloat("score");
            _currentScore += 15;
            PlayerPrefs.SetFloat("score", _currentScore);
        }
    }
}
