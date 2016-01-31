using UnityEngine;
using System.Collections;

public class Team : MonoBehaviour {

	public ArrayList effects; // references to all active effects on this team
	public Player player; // references to all the players in the team

    public UnityEngine.Color teamColor;
    public int score = 0;

	[SerializeField] public int teamID;
	[SerializeField] public TextMesh playerDisplay;
	[SerializeField] public TextMesh scoreDisplay;


	// Use this for initialization
	void Start () {
		playerDisplay.text = "Player: " + teamID.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		scoreDisplay.text = "Score: " + score.ToString ();
	}

    public void addScore(int score) {
        this.score += score;
    }
    public bool spendSouls(int souls) {
        if (score - souls < 0) {
            return false;
        }
        else {
            score -= souls;
            return true;
        }
    }
}
