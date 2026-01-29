using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    // Variables that will be provided for calculation
    public float bookCost;
    public int bookCopies;

    // Variables for calculating discount & shipping costs
    private float discount = 0.4f; // 40% Discount is hard-coded to avoid issues with user input
    public float firstShipping;
    public float generalShipping;

    // Variables that will be calculated & output at the end of the method
    private float purchaseCost;
    private float shippingCost;
    private float wholesaleCost;
    private float profit;

    // Start is called before the first frame update
    void Start()
    {
        // Calculates the price of the bookstore purchasing books with the discount applied
        purchaseCost = (bookCost - (bookCost * discount)) * bookCopies; 

        // Calculates shipping cost for the book purchase 
        shippingCost = firstShipping + (generalShipping * (bookCopies - 1));

        // Calculates and stores the wholesale cost & the profit from customers
        wholesaleCost = purchaseCost + shippingCost;
        profit = bookCost * bookCopies;

        // Outputs wholesale cost & profit 
        Debug.Log("\nWholesale Cost: " + wholesaleCost + "\nProfit: " + profit);

    }
}
