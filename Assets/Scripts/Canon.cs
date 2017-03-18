using UnityEngine;

public class Canon : MonoBehaviour 
{
	public float fireRate = 1f;
	public Transform spawnPosition;
	public Rigidbody bullet;
	public float bulletSpeed;
	private float elapsedTime;
	private Vector3 direction;
	
	private void Start ()
	{
		direction = GetDirection ();
	}

	private void Update () 
	{
		elapsedTime += Time.deltaTime;
		if (elapsedTime >= fireRate)
		{
			Shoot ();
			elapsedTime = 0f;
		}
	}

	private void Shoot ()
	{
		Vector3 position = spawnPosition.position;
		Vector3 velocity = direction * bulletSpeed;
		//TODO: Shoot bullet
	}

	private Vector3 GetDirection ()
	{
		Vector3 distance = spawnPosition.position - transform.position;
		return Vector3.right * Mathf.Sign (distance.x); 
	}
}
