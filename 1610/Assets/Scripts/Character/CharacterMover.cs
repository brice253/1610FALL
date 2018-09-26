using UnityEngine;

public class CharacterMover : MonoBehaviour 
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
        position.y = Speed * Input.GetAxis("Vertical");
        Controller.Move(position*Time.deltaTime);

	}
}
