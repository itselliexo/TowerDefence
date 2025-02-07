using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    [Header("Script references")]
    //[SerializeField] private DayManager dayManager;

    [Header("General stats:")]
    [SerializeField] public bool hasHome;
    [SerializeField] public bool canHaveMortgage;
    [SerializeField] public bool hasMortgage;

    [Header("Daily needs:")]
    [SerializeField] public bool didHygiene;
    [SerializeField] public bool hasEaten;

    [Header("Weekly needs:")]
    [SerializeField] public bool doneLaundry;
    [SerializeField] public bool paidRent;
    [SerializeField] public bool doneArt;

    [Header ("Energy stats")]
    [SerializeField] public float energy = 100f;
    [SerializeField] private float energyOverflow = 25f;
    [SerializeField] private float groceryShoppingEnergyCost;
    [SerializeField] private float cookingEnergyCost;
    [SerializeField] private float workDayEnergyCost;

    [Header("Health Stats:")]
    [SerializeField] public float currentHealth;
    [SerializeField] public float maxHealth;
    [SerializeField] private float sicknessPenalty;
    [SerializeField] private float addictionPenalty;

    [Header("Morale stats:")]
    [SerializeField] public float morale;
    [SerializeField] public float maxMorale;
    [SerializeField] public float workPenalty;
    [SerializeField] private float laundryPenalty;
    [SerializeField] private float noHousePenalty;
    [SerializeField] private float hygienePenalty;
    [SerializeField] private float noArtPenalty;

    [Header("Hunger stats:")]
    [SerializeField] public float currentHunger;
    [SerializeField] public float maxHunger;
    
    [Header("Money stats:")]
    [SerializeField] public double currentMoney;
    [SerializeField] public double salary;
    [SerializeField] public int daysOverdueForRent;
    [SerializeField] public int rentGrace = 3;
    [SerializeField] private int daysInRent = 7;
    [SerializeField] public double rentCost;
    [SerializeField] public double billCost;
    [SerializeField] public double groceryCost;

    [Header("Work Stats:")]
    [SerializeField] public bool isEmployed;
    [SerializeField] public int daysWorkedInRow;
    [SerializeField] public int sickDaysTaken;
    [SerializeField] private int maxPaidSickDays = 7;
    [SerializeField] public bool calledInSick;
    [SerializeField] public bool forcedToWorkWhileSick;

    [Header("Addiction Stats:")]
    [SerializeField] public bool isAddicted;
    [SerializeField] private int addictionThreshold = 7;
    [SerializeField] public int daysSmoking;
    [SerializeField] public float healthPenaltyFromSmoking;
    [SerializeField] public double smokingCost = 20;



    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void EvictPlayer()
    {
        Debug.Log("Player evicted");
    }

    void RentHouse()
    {
        Debug.Log("House rented");
    }

    void ApplyForMortgage()
    {
        Debug.Log("Mortgage applied for");
    }

    void PersonalHygiene()
    {
        Debug.Log("Player is clean");
    }

    void Eat()
    {
        Debug.Log("Player ate.");
    }

    void DoLaundry()
    {
        Debug.Log("Player did laundry");
    }

    void PayRent()
    {
        Debug.Log("Rent paid");
    }

    void DoArt()
    {
        Debug.Log("Player did art");
    }

    void GoGroceryShopping()
    {
        Debug.Log("Player went grocery shopping");
    }

    void Work()
    {
        Debug.Log("Player went to work");
    }

    void CallInSick()
    {

    }

    void PayBills()
    {
        Debug.Log("Player payed bills");
    }
}
