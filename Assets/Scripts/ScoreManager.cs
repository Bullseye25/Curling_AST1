using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager instance = null;

	private float m_radiusSize;

    private Text m_p1Score, m_p2Score;

	public List<GameObject> list = new List<GameObject>();

	private void Awake()
	{
		if (instance == null)
			instance = this;
	}

    void Start()
    {
		m_radiusSize = transform.parent.localScale.x;

		m_p1Score = GameObject.Find("_P1Score").GetComponent<Text>();
		m_p2Score = GameObject.Find("_P2Score").GetComponent<Text>();
    }

    internal void CalculateScores()
    {
        list.Sort(ByDistance);

        int p1 = 0, p2 = 0;

        for (int i = 0; i < list.Count; i++)
        {
            if(list[i].gameObject.name == "Stones_p1_Stone")
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
        var dstToA = Vector3.Distance(transform.position, a.transform.position);
	
        var dstToB = Vector3.Distance(transform.position, b.transform.position);
	    
        return dstToA.CompareTo(dstToB);
	}

    internal void GetClosestStones()
    {
        foreach (GameObject _stone in GameObject.FindGameObjectsWithTag("Stone"))
        {
            float a_dis = Vector3.Distance(_stone.transform.position, transform.position);

            a_dis = a_dis / 10;

            if (a_dis < m_radiusSize)
            {
                if (!list.Contains(_stone))
                    list.Add(_stone);
            }
        }
    }
}
