using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    private StarDispaly starDisplay;
    public int starCoast ;

    private void Start()
    {
        starDisplay = GameObject.FindObjectOfType<StarDispaly>();
    }
    public void AddStars(int amount)
    {
        starDisplay.AddStars(amount);
    }

}
