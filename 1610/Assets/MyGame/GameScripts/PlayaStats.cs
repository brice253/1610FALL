using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayaStats : MonoBehaviour
{
    public FloatData PlayerHealth;

    private void Update()
    {
        if (PlayerHealth.Value <= 0)
        {
            Debug.Log("DEAD");
        }
    }
}
