using UnityEngine;
using System.Collections;

public class CubeBehavior : MonoBehaviour {
	public OreType myType;

	// Use this for initialization
	void Start () {
		if (myType == OreType.Bronze) {
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
		else if (myType == OreType.Silver) {
			gameObject.GetComponent<Renderer>().material.color = Color.white;
		}
		else if (myType == OreType.Gold) {
			gameObject.GetComponent<Renderer>().material.color = Color.yellow;
		}
	}
	void OnMouseDown () {
		Destroy(gameObject);

		//GameControllerScript.whatever-- makes the count of that color cube go down when you click
		//GameControllerScript.Score += Whatever adds the amount of points the cube is worth to your overall score
		if (myType == OreType.Bronze) {
			GameControllerScript.bronzeCount--;
			GameControllerScript.score += GameControllerScript.bronzePoints;
		}
		else if (myType == OreType.Silver) {
			GameControllerScript.silverCount--;
			GameControllerScript.score += GameControllerScript.silverPoints;
		}
		else if (myType == OreType.Gold) {
			GameControllerScript.goldCount--;
			GameControllerScript.score += GameControllerScript.goldPoints;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
