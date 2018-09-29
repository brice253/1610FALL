using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour {
    string myName = "Brad";

    private void Start()
    {
        myName = FullName(" Rice");
        Debug.Log(myName);
    }

    string FullName(string last)
    {
        string lastName;

        lastName = myName + last;

        return lastName;
    }


}
