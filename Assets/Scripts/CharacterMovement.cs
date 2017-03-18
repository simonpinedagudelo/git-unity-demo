using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class CharacterMovement : MonoBehaviour 
{
	public float speed = 100f;
	public float jumpSpeed = 100f;
	private new Rigidbody rigidbody;

	private void Awake ()
	{
		rigidbody = GetComponent<Rigidbody> ();
	}

	private void Update () 
	{
		Move ();
		if (Input.GetKeyDown (KeyCode.Space))
			Jump ();
	}

	private void Move ()
	{
		Vector3 velocity = rigidbody.velocity;
		velocity.x = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		rigidbody.velocity = velocity;
		Debug.Log (velocity);
	}

	private void Jump ()
	{
		//TODO: 
	}
}
