using UnityEngine;

public class CharacterMove : MonoBehaviour 
{

    public CharacterController Controller;
    private Vector3 position;
    public float Speed = 3.0f;

	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        position.x = Speed * Input.GetAxis("Horizontal");
        position.z = Speed * Input.GetAxis("Vertical");
        Controller.Move(position*Time.deltaTime);

	}
}
