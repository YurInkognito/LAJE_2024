using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNigthCicle : MonoBehaviour
{
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
        // Show the income screen
        incomeScreen.SetActive(true);
        incomeText = "Income for Day " + currentDay + ": " + dailyIncome;

        // Reset the day cycle
        currentDay++;
        dailyIncome = 0; // Reset or carry over if needed
        UpdateDayText();
        incomeScreen.SetActive(false);
        nextDayButton.SetActive(false);
    }

    void UpdateDayText()
    {
        dayText = "Day " + currentDay;
    }

    // Call this when the player earns money
    public void AddIncome(int amount)
    {
        dailyIncome += amount;
    }
}
