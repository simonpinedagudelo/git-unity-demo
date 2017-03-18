using UnityEngine;

public class Bullet : MonoBehaviour 
{
	public float damage = 10f;

	private void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.CompareTag ("Player"))
			;//TODO: Apply Damage
		Destroy (gameObject);
	}
}
