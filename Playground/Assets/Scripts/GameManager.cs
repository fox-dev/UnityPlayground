using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour {

	public GameObject[] roadPrefab;
	public float createTime = 0;
	public float timeToCreate = 0;
	/// <summary>
	/// The road.
	/// </summary>
	private ArrayList theRoad = new ArrayList();
	private int firstIndex = 0;


	int x = 0;
	// Use this for initialization
	void Start () {
		//for (int x = 0; x < 100; x++) 
		//{
			//int value = Random.Range(0,2);
			//GameObject temp = Instantiate(roadPrefab[value], new Vector3 (x + roadPrefab[value].gameObject., 0, 0), Quaternion.identity) as GameObject;
		//}

	
	}
	
	// Update is called once per frame
	void Update () {

		/*
		if(Input.GetButtonDown("Fire1"))
		{
			int value = Random.Range(0,2);

			GameObject temp = Instantiate(roadPrefab[value], new Vector3 (x, 0, 0), Quaternion.identity) as GameObject;
			x = x + 1;

		
;
		}
		*/
		createTime += Time.deltaTime;
		if (createTime >= timeToCreate)
		{
			int value = Random.Range(0,2);
			//GameObject temp = Instantiate(roadPrefab[value], new Vector3 (x, 0, 0), Quaternion.identity) as GameObject;
			theRoad.Add(Instantiate(roadPrefab[value], new Vector3 (x, 0, 0), Quaternion.identity));
			x = x + 10;
			createTime = 0;
			if(theRoad.Count > 3)
			{
				Destroy((GameObject)theRoad[firstIndex]);
				firstIndex++;
			}


		}


		print (theRoad.Count);
	

	
	}
}
