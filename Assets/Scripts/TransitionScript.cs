using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionScript : MonoBehaviour 
{
    public static TransitionScript instance = null;

	private int m_totalTurns = 7, m_turn = 0, m_amountOfStones = 4, m_end = 9, m_totalEnds = 10;
	
    private Text m_p1TotalScore, m_p2TotalScore, m_winningTitle;

    public List<Text> m_p1EndScore = new List<Text>(), m_p2EndScore = new List<Text>();

	private float m_radiusSize;

    private List<GameObject> m_stonesInHouse = new List<GameObject>();

    [Header("Stone Images Displayed On The Scene")]
    public List<GameObject> m_stonesUIImages = new List<GameObject>();

	[Header("House")]
    public Transform m_house;

	private List<GameObject> m_p1Stones = new List<GameObject>(), m_p2Stones = new List<GameObject>();

    private GameObject m_scoringPanel;

    internal void Awake()
	{
		if (instance == null)
			instance = this;
	}

	void Start()
	{
		m_radiusSize = m_house.parent.localScale.x;

		m_p1TotalScore = GameObject.Find("_P1Score").GetComponent<Text>();

		m_p2TotalScore = GameObject.Find("_P2Score").GetComponent<Text>();

        m_p1Stones = PoolingManager.instance.CreatePool(Pool.Stones_p1_Stone, m_amountOfStones);

        m_p2Stones = PoolingManager.instance.CreatePool(Pool.Stones_p2_Stone, m_amountOfStones);

        m_p1EndScore = GetEndScoringTexts("P1_SCORING");

		m_p2EndScore = GetEndScoringTexts("P2_SCORING");

        m_winningTitle = GameObject.Find("PlayerNameText").GetComponent<Text>();

        m_scoringPanel = GetScoringPanel();
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
			m_end++;

            ControllerScript.instance.m_stoneClone = false;

            ControllerScript.instance.NextTurn();

            GetClosestStones();

            CalculateScores();

            ResetTurn();

            ActivateScoringPanel();
        }
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

        m_stonesInHouse.Clear();
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

	private void CalculateScores()
	{
		m_stonesInHouse.Sort(ByDistance);

		int p1 = 0, p2 = 0;

		for (int i = 0; i < m_stonesInHouse.Count; i++)
		{
			if (m_stonesInHouse[i].gameObject.name == "Stones_p1_Stone")
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

    private void DisplayScores(int a_p1, int a_p2)
    {
        if (a_p1 > a_p2)
        {
            SetScore(a_p1, m_p1TotalScore, m_p1EndScore, m_p2EndScore);
            SetWinningTitle("Player 1");
        }
        else
        {
            SetScore(a_p2, m_p2TotalScore, m_p2EndScore, m_p1EndScore);
            SetWinningTitle("Player 2");
        }

        if (m_end >= m_totalEnds)
        {
            DiclearFinalScore(a_p1, a_p2);
        }
    }

    private void DiclearFinalScore(int a_p1, int a_p2)
    {
        int p1 = System.Int32.Parse(m_p1TotalScore.text) + a_p1;

        int p2 = System.Int32.Parse(m_p2TotalScore.text) + a_p2;

        if(p1 > p2)
        {
			m_winningTitle.text = "CONGRATULATIONS"+ "\n" + "PLAYER 1" + "\n" + "WINS" + "\n" + "MATCH";
        }
        else
        {
			m_winningTitle.text = "CONGRATULATIONS" + "\n" + "PLAYER 2" + "\n" + "WINS" + "\n" + "MATCH";
        }
	}

    private void SetScore(int a_playerScore, Text a_totalScoringTextDisplay, List<Text> a_winnerEndScore, List<Text> a_loserEndScore)
    {
		int playerTotalScore = System.Int32.Parse(a_totalScoringTextDisplay.text) + a_playerScore;
		a_totalScoringTextDisplay.text = playerTotalScore.ToString();
		a_winnerEndScore[m_end].text = a_playerScore.ToString();
        a_winnerEndScore[a_loserEndScore.Count-1].text = playerTotalScore.ToString();
		a_loserEndScore[m_end].text = "0";
	}

    private void SetWinningTitle(string a_playerID)
    {
        m_winningTitle.text = a_playerID + "\n" + "WINS" + "\n" + "END " + m_end;
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
				if (!m_stonesInHouse.Contains(_stone))
					m_stonesInHouse.Add(_stone);
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

    private List<Text> GetEndScoringTexts(string a_parentObject)
    {
        List<Text> _list = new List<Text>();

        GameObject m_endScoringPanel = GameObject.Find(a_parentObject);

        foreach(Transform _score in m_endScoringPanel.transform)
        {
            _list.Add(_score.GetChild(0).GetComponent<Text>());
        }

        return _list;
    }

    private GameObject GetScoringPanel()
    {
        GameObject a_scoringPanel = GameObject.Find("_MainScoringCanvas");
		a_scoringPanel.transform.SetParent(null);
		a_scoringPanel.SetActive(false);

        return a_scoringPanel;
    }

    private void ActivateScoringPanel()
    {
        m_scoringPanel.SetActive(true);
    }

    public void ClearScoreBoard()
    {
        if (m_end >= m_totalEnds)
        {
            ClearScoreBoards(m_p1TotalScore, m_p1EndScore);

            ClearScoreBoards(m_p2TotalScore, m_p2EndScore);

			m_end = 0;
        }
    }

    private void ClearScoreBoards(Text a_displayedScore, List<Text> a_endScoreBoard)
    {
        a_displayedScore.text = "0";

        for (int i = 1; i < a_endScoreBoard.Count; i++)
        {
            a_endScoreBoard[i].text = "-";
        }
    }
}
