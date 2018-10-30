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
				case GameWeapons.Weapons.Sword:
					print("Player is using a sword");
					break;
				
				case GameWeapons.Weapons.Axe:
					print("Player is using a axe");
					break;
				
				case GameWeapons.Weapons.Bow:
					print("Player is using a bow");
					break;
				
				case GameWeapons.Weapons.Spear:
					print("Player is using a spear");
					break;
				
				case GameWeapons.Weapons.Shoe:
					print("Player is using a shoe");
					break;
					
		}
	}
}
