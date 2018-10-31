using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements3 : MonoBehaviour
{

	public GameBehaviours.Behaviours Needs;
	
	// Update is called once per frame
	void Update () {
		switch (Needs)
		{
			case GameBehaviours.Behaviours.Dying:
				print("Your dying!");
				break;
				
			case GameBehaviours.Behaviours.Eating:
				print("Nom Nom.");
				break;
			
			case GameBehaviours.Behaviours.Sleeping:
				print("ZZZZ....");
				break;
			
			case GameBehaviours.Behaviours.Starving:
				print("Your stomach grumbles..");
				break;
		}
	}
}
