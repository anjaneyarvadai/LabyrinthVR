using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public GameObject door;

	public Renderer rend;

	void Start()
	{
		rend = GetComponent<Renderer>();
		rend.material.color = Color.green;


	}

	void Update()
	{
		//Bonus: Key Animation

		transform.Rotate(Vector3.up, Time.deltaTime*200);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Destroy the key. Check the Unity documentation on how to use Destroy
		GameObject go = (GameObject)Instantiate(keyPoof);
		go.transform.position = transform.position;
		gameObject.SetActive(false);
		//door.GetComponent<Door>().locked = true;
		door.GetComponent<Door>().Unlock();

    }

}
