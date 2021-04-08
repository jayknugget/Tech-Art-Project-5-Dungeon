using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	//private float speed;
	public float moveSpeed = 5f;

	public Rigidbody2D rb;

	Vector2 movement;

	// Use this for initialization
	//void Start () {

	//}

	// Update is called once per frame

	void Update()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
	}
	void FixedUpdate () {

		rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
		//float horizontal = Input.GetAxis ("Horizontal");
		//float vertical = Input.GetAxis ("Vertical");

	//	GetComponent<Rigidbody2D> ().velocity = new Vector2 (horizontal * speed, vertical * speed);
	}
}
