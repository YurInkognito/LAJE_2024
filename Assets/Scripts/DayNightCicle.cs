using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNigthCicle : MonoBehaviour
{
<<<<<<< HEAD
    public float dayDuration = 600f; 
    public Text dayText;
=======
    public string dayText;
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
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

<<<<<<< HEAD
        currentTime = dayDuration;
        isNight = false;
=======
        // Reset the day cycle
>>>>>>> 227ba8e4373315380d6cc0e720b4a7556c1b6c36
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
