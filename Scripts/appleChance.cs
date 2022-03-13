using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Apple", fileName = "New Apple")]
public class appleChance : ScriptableObject
{
    public int random = Random.Range(0,4);

}
