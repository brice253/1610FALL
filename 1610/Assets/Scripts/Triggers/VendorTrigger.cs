using UnityEngine;
using UnityEngine.Events;

public class VendorTrigger : MonoBehaviour 
{
    
    public UnityEvent Trigger;

    void OnTriggerEnter()
    {
        Trigger.Invoke();
    }

}
