using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour 
{
    public int A;
    public int B;
    public int C;

    void Update()
    {
        if (A + B == C)
        {
            print("Correct");
        }
        else
        {
            print("Incorrect");
        }
    }	
}
