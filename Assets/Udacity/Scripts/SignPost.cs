using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public GameObject door;

	public void ResetScene() 
	{
		SceneManager.LoadScene("Maze");
		door.GetComponent<Door>().doorClose();
	}
}