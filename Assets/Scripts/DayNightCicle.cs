using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNigthCicle : MonoBehaviour
{
    public float dayDuration = 600f; 
    public Text dayText;
    public GameObject nextDayButton;
    public GameObject incomeScreen;
    public Text incomeText;

    private float currentTime;
    private bool isNight = false;
    private int currentDay = 1;
    private int dailyIncome = 0;

    void Start()
    {
        currentTime = dayDuration;
        UpdateDayText();
        incomeScreen.SetActive(false);
    }

    void Update()
    {
        if (!isNight)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                EnterNightMode();
            }
        }
    }

    void EnterNightMode()
    {
        isNight = true;
        nextDayButton.SetActive(true);
        dayText.text = "The shop doesn't work at night.";
    }

    public void NextDay()
    {
        incomeScreen.SetActive(true);
        incomeText.text = "Income for Day " + currentDay + ": " + dailyIncome;

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
        dayText.text = "Day " + currentDay;
    }

    public void AddIncome(int amount)
    {
        dailyIncome += amount;
    }
}
