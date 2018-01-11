using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;       //Public variable to store a reference to the player game object


	private Vector3 offset;         //Private variable to store the offset distance between the player and camera

	private float y;


	// Use this for initialization
	void Start () 
	{
		y = transform.position.y;
	}

	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		/*transform.position=transform.position + new Vector3(player.transform.rotation.x,
			0,player.transform.rotation.z);*/
		//transform.position = player.transform.position + offset;
		transform.Translate(0,0,0.1f,Camera.main.transform); //Esto es una prueba
		transform.position=new Vector3(transform.position.x,y,transform.position.z);
		Debug.Log("X "+player.transform.rotation.x.ToString()+" Z "+player.transform.rotation.z.ToString());
		//transform.position= transform.position+new Vector3(1,0,0);

	}
}
