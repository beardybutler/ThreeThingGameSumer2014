using UnityEngine;
using System.Collections;

public class Boop : MonoBehaviour
{
	public void Update() {
		GameObject sd = GameObject.Find ("ScrewDriverPickup");
		GameObject op = GameObject.Find("OculusPlayer");
		if (sd != null && op != null) {
						Vector3 distance = sd.transform.position - op.transform.position;
						if (distance.magnitude < 5) {
								//Debug.Log("Collect");
								Destroy (sd);
						}
				}
		}
	/*void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Capsule") 
		{
			Destroy (col.gameObject);
		}
						
				
	}*/
}