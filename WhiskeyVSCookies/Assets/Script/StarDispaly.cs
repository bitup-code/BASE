using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDispaly : MonoBehaviour
{
    private Text starText;
    private int stars = 100;
    public enum Status { SUCCESS, FAILURE };
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisolay();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisolay();
    }

    public Status UseStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisolay();
            return Status.SUCCESS;
        }
        else
        {
            return Status.FAILURE;
        }
        
    }
    private void UpdateDisolay()
    {
        starText.text = stars.ToString();
    }
}
