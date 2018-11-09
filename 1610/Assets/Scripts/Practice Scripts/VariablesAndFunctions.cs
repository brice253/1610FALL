using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour {
    int myAge = 23;

    int FutureAge(int NewAge){
        int future;

        future = NewAge * myAge;

        return future;
    }

    private void Start()
    {
        myAge = FutureAge(12);
        Debug.Log(myAge);
    }

}
