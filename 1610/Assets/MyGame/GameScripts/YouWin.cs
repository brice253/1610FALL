using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You Win!");
    }
}
