using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {

    public bool LightOn;
    public string Password;
    public int A, B, C;

    public FloatData WizardPower, PawnPower;
    public NameId Lock, Key;

	// Update is called once per frame
	void Update () 
    {
        if(Lock == Key)
        {
            print("Open door.");
        }

        if(WizardPower.Value > PawnPower.Value)
        {
            print("Wizard wins!");
        }
        else
        {
            print("Pawn wins!");
        }

        if(LightOn)
        {
            print("The Light is on.");
        }
        else
        {
            print("The Light is off.");
        }

        if(Password == "OU812")
        {
            print("Password is correct");
        }
        else
        {

        }

        if(C == A + B)
        {
            print(C);
        }
        else
        {

        }
	}
}
