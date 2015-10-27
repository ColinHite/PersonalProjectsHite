using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		var move = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		{
			GetComponent<Rigidbody2D> ().position = move * speed * Time.deltaTime;
		}
	}
}
