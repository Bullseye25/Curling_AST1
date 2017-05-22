using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionScript : MonoBehaviour 
{
    public static TransitionScript instance = null;

	private int m_totalTurns = 7, m_turn = 0;
	
    private Text m_p1Score, m_p2Score;

	private float m_radiusSize;

	public List<GameObject> list = new List<GameObject>();

    public List<GameObject> m_stonesUIImages = new List<GameObject>();

    public Transform m_house;

	private List<GameObject> m_p1Stones = new List<GameObject>(), m_p2Stones = new List<GameObject>();

	private int m_amountOfStones = 4;

    internal void Awake()
	{
		if (instance == null)
			instance = this;
	}

	void Start()
	{
		m_radiusSize = m_house.parent.localScale.x;

		m_p1Score = GameObject.Find("_P1Score").GetComponent<Text>();

		m_p2Score = GameObject.Find("_P2Score").GetComponent<Text>();

        m_p1Stones = PoolingManager.instance.CreatePool(Pool.Stones_p1_Stone, m_amountOfStones);

        m_p2Stones = PoolingManager.instance.CreatePool(Pool.Stones_p2_Stone, m_amountOfStones);
    }

    //following mehtod will be called whenever there is a need to reset the properties of the stone
    public void ActiveController(int a_activationValue)
    {
        //if there is a new turn is over..
        if (a_activationValue >= 1)
        {
            //reset the properties of the stone to default, placing the stone to the starting position..
            ControllerScript.instance.ResetStoneProperties();
        }

        //if the turn is over..
        else
        {
            //disable the controls and the stone..
            ControllerScript.instance.gameObject.SetActive(false);
        }
    }

    public void NextTurn()
    {
		if (m_turn < m_totalTurns)
        {
            ControllerScript.instance.NextTurn();

			RemoveOneUIStone();

            m_turn++;

        }
        else if (m_turn >= m_totalTurns)
        {
			ControllerScript.instance.m_stoneClone = false;

			ControllerScript.instance.NextTurn();
            
            GetClosestStones();

            CalculateScores();

            ResetTurn();

        }

		Debug.Log("turn  : " + m_turn);
    }

    private void RemoveOneUIStone()
    {
        m_stonesUIImages[m_turn].SetActive(false);
    }

    //following disables the transition..
    public void TransitionDisabler()
    {
        this.gameObject.SetActive(false);
    }

    private void ResetTurn()
	{
		m_turn = 0;

        ActivateStonsUI();

        list.Clear();
	}

    private void ActivateStonsUI()
    {
        foreach(GameObject _stone in m_stonesUIImages)
        {
            _stone.SetActive(true);
        }

        foreach (GameObject _stone in GameObject.FindGameObjectsWithTag("Stone"))
        {
            if(_stone.GetComponent<ControllerScript>() == null)
            {
                _stone.SetActive(false);
            }
        }
    }

	internal void CalculateScores()
	{
		list.Sort(ByDistance);

		int p1 = 0, p2 = 0;

		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].gameObject.name == "Stones_p1_Stone")
			{
				if (p2 == 0)
					p1++;
				else
					break;
			}
			else
			{
				if (p1 == 0)
					p2++;
				else
					break;
			}
		}

		DisplayScores(p1, p2);
	}

	internal void DisplayScores(int a_p1, int a_p2)
	{
		if (a_p1 > a_p2)
		{
			int p1 = System.Int32.Parse(m_p1Score.text) + a_p1;
			m_p1Score.text = p1.ToString();
		}
		else
		{
			int p2 = System.Int32.Parse(m_p2Score.text) + a_p2;
			m_p2Score.text = p2.ToString();
		}
	}

	internal int ByDistance(GameObject a, GameObject b)
	{
		var dstToA = Vector3.Distance(m_house.position, a.transform.position);

		var dstToB = Vector3.Distance(m_house.position, b.transform.position);

		return dstToA.CompareTo(dstToB);
	}

	internal void GetClosestStones()
	{
		foreach (GameObject _stone in GameObject.FindGameObjectsWithTag("Stone"))
		{
            float a_dis = Vector3.Distance(_stone.transform.position, m_house.position);

			a_dis = a_dis / 10;

			if (a_dis < m_radiusSize)
			{
				if (!list.Contains(_stone))
					list.Add(_stone);
			}
		}
	}

	//this method will take the last position of the rolling stone that is thrown and will replace will a clone of a stone which will not have player controls
    internal void MakeNewStone()
	{
        if (IsOdd())
		{
			PoolingManager.instance.GetActiveObject(m_p2Stones, ControllerScript.instance.transform.position);
		}
		else
		{
			PoolingManager.instance.GetActiveObject(m_p1Stones, ControllerScript.instance.transform.position);
		}
	}

	//following method will be used to determine which turn it is..
	internal bool IsOdd()
	{
        return m_turn % 2 != 0;
	}
}
