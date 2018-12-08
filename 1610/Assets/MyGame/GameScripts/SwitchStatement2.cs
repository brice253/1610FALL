using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;

public class SwitchStatement2 : MonoBehaviour
{

	public GameWeapons.Weapons GameWeapon;

	void Update () {
		switch (GameWeapon)
		{
				case GameWeapons.Weapons.Shotgun:
					print("Player is using a shotgun");
					break;
				
				case GameWeapons.Weapons.Chainsaw:
					print("Player is using a chainsaw");
					break;
				
				case GameWeapons.Weapons.Rifle:
					print("Player is using a rifle");
					break;
				
				case GameWeapons.Weapons.Pistol:
					print("Player is using a pistol");
					break;
				
				case GameWeapons.Weapons.Shoe:
					print("Player is using a shoe");
					break;
					
		}
	}
}
