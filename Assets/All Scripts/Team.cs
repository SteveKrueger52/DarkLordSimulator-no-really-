using UnityEngine;
using System.Collections;

public class Team : MonoBehaviour {

	public ArrayList effects; // references to all active effects on this team
	public ArrayList players; // references to all the players in the team
	private int teamID;
    public UnityEngine.Color teamColor;
    public int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
        }
    }
}
