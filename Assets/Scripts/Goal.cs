using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour 
{
	public Text winLabel;

	private void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Player"))
			Win ();
	}

	private void Win ()
	{
		//TODO: Activate win label
	}
}
