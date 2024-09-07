using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNigthCicle : MonoBehaviour
{

    public float dayDuration = 600f; 
    public string dayText;
    public GameObject nextDayButton;
    public GameObject incomeScreen;
    public string incomeText;

    private float currentTime;
    private bool isNight = false;
    private int currentDay;
    private int dailyIncome;

    void Start()
    {
        UpdateDayText();
        incomeScreen.SetActive(false);
    }

    void EnterNightMode()
    {
        isNight = true;
        nextDayButton.SetActive(true);
        dayText = "The shop doesn't work at night.";
    }

    public void NextDay()
    {
        incomeScreen.SetActive(true);
        incomeText = "Income for Day " + currentDay + ": " + dailyIncome;

        currentTime = dayDuration;
        isNight = false;

        currentDay++;
        dailyIncome = 0; 
        UpdateDayText();
        incomeScreen.SetActive(false);
        nextDayButton.SetActive(false);
    }

    void UpdateDayText()
    {
        dayText = "Day " + currentDay;
    }

    public void AddIncome(int amount)
    {
        dailyIncome += amount;
    }
}
