using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.SceneManagment;

public class Test: MonoBehaviour
{
	Rigidbody rb; //adding physics
	public GameObject winText; //Displaying text on screen
	float xInput;
	float zInput;

	public float speed;


	void Start()
	{
		//Destroy(gameObject,3f); //Destroys objects
		rb= GetComponent<Rigidbody>();
	}

	void Update()
	{
		if(Input.GetKeyDown(Keycode.Space))	//Taking keyboard inputs
		{
			// Destroy(gameObject);
			rb.AddForce(Vector3.up * 500); //Adding force to the object
		}
		//rb.velocity =Vector3.forward * 20f; //Moving object with velocity

		if(Input.GetKeyDown(Keycode.r))
		{
			SceneManager.LoadScene("Level2");
		}

		xInput = Input.GetAxis("Horizontal");
		zInput = Input.GetAxis("Vertical");

		rb.AddForce(xInput*speed, 0, zInput*speed);
	}

	private void OnMouseDown()
	{
	 	Destroy(gameObject);
	}
	private void OnCollisionsEnter(Collision collision) //Deceting collisions+
	{
		if(collision.gameObject.tag=="Enemy")
		{
			Destroy(collisiom.gameObject);

			winText.SetActive(true);
		}
	}
}