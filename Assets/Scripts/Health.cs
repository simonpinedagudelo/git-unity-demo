using UnityEngine;

public class Health : MonoBehaviour 
{
	public float lifePoints = 100f;
	
	public void ApplyDamage (float damage)
	{
		lifePoints -= damage;
		//TODO: Die
	}
}
