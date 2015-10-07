using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {

	float timeToAct = 0.0f;
	float spawnTime = 3.0f;

	//CubePrefabs
	public GameObject bronzePrefabCube;
	public GameObject silverPrefabCube;
	public GameObject goldPrefabCube;

	//Cube counts
	public static int bronzeCount = 0;
	public static int silverCount = 0;
	public static int goldCount = 0;

	//Cube Points
	public static int bronzePoints = 1;
	public static int silverPoints = 10;
	public static int goldPoints = 100;

	//Initial score 
	public static int score = 0;

	//This variable doesn't let gold spawn twice
	private bool recentlySpawnedGold = false;
	
	// Use this for initialization
	void Start () {

		timeToAct += spawnTime;

	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= timeToAct) {

			//gold is checked first, because it is highest priority
			// but not 2 in a row

			if (bronzeCount == 2 && silverCount == 2 && recentlySpawnedGold == false) {
				Instantiate(goldPrefabCube,
				            new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0),
				            Quaternion.identity);
				goldCount++;
				recentlySpawnedGold = true;
			}
			else if (bronzeCount < 4) {
				Instantiate(bronzePrefabCube,
				            new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0),
				            Quaternion.identity);
				bronzeCount++;
				recentlySpawnedGold = false;
			}
			else if (bronzeCount >= 4) {
				Instantiate(silverPrefabCube,
				            new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0),
				            Quaternion.identity);
				silverCount++;
				recentlySpawnedGold = false;
			}

			timeToAct += spawnTime;
		}
	}
}
