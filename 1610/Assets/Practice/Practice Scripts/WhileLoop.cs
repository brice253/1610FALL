using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    float money = 0.00f;


    void Start()
    {
        while (money > 0)
        {
            Debug.Log("I've got "+money+"!");
            money--;
        }
    }
}