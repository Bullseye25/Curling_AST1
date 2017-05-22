using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Pool
{
    Stones_p2_Stone,
    Stones_p1_Stone,
};

public class PoolingManager : MonoBehaviour
{
	// list of object that will have the pool their individual pool
	public GameObject[] m_pooledObject;

	public static PoolingManager instance = null;

	//Awake is always called before any Start functions
	void Awake()
	{
		if (instance == null)
			instance = this;
	}

	// Use this for initialization
    internal List<GameObject> CreatePool(Pool a_object, int a_amount)
	{
		//creating a new list to hold stones in as a gameobject
		List<GameObject> a_list = new List<GameObject>();

		//checking each object given in the array,
		for (int i = 0; i < m_pooledObject.Length; i++)
		{
			//if one of object's name matches
			if (m_pooledObject[i].name == a_object.ToString())
			{
                //create certain amount of objects according to the amount provided,
				for (int j = 0; j < a_amount; j++)
				{
					// creating the object
					GameObject _object = Instantiate(m_pooledObject[i]) as GameObject;

                    _object.name = a_object.ToString();

					//placing it inside the holder/list
					a_list.Add(_object);

					//disable the object
					_object.SetActive(false);
				}

				return a_list;
			}

		}
		return null;
	}

	//this function gets the available object in the pool
    internal void GetActiveObject(List<GameObject> a_pool, Vector3 a_objectPlacingPosition)
	{
		//get the objects in the pool
		foreach (GameObject a_object in a_pool)
		{
			//if the object in not active
			if (!a_object.gameObject.activeInHierarchy)
			{
				//change the postion of that object to certain location
				a_object.transform.position = a_objectPlacingPosition;
				//activate that objecet
				a_object.gameObject.SetActive(true);

                break;
			}
		}
	}

    //this function clears the pool
	internal void Clear(List<GameObject> a_list)
	{
		//get all the object in the pool
		foreach (GameObject _object in a_list)
		{
			//destroy the object
			Destroy(_object);
		}
	}
}
