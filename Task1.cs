using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // initialize totalDollars publicly so it can be changed in inspector
    public int totalDollars;
    private int dollars;

    // initialize string for outputting values
    private string output = "";

    void Start()
    {
        // create arrays for the values/names of each bill
        int[] billValues = { 100, 50, 20, 10, 5, 1 };
        string[] billNames = {"Hundred(s): ", "Fifty(s): ", "Twenty(s): ", "Ten(s): ", "Five(s): ", "One(s): "};

        // goes through each bill in the array, divides by value and finds remainder
        for (int i = 0; i<billValues.Length; i++) {
		    int amountInBills = dollars / billValues[i];
            dollars %= billValues[i];

            // debug statement to show the for loop & logic is working properly
            Debug.Log("\nAmount in Bills: " + amountInBills + "\nDollars: " + dollars + "\nBill in Values: " + billValues[i]);
		
		    // adds bill name + value for output
		    output += billNames[i] + billValues[i] + "\n";
        }

        // outputs everything
        // FIXME: output is incorrect despite logic & loop output being correct
        Debug.Log(output);
	}
}
