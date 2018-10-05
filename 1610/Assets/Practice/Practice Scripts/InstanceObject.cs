using UnityEngine;

public class InstanceObject : MonoBehaviour 
{

    public GameObject Instance;
	private void Start () 
    {
        Instantiate(Instance);
		
	}
}
