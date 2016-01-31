using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    ArrayList gameObjects;

    [SerializeField] uint playerCount;

    private Player[] players;

    [SerializeField] Player player1;
    [SerializeField] Player player2;
    [SerializeField] Player player3;
    [SerializeField] Player player4;

    [SerializeField] Map Arena;

	// Use this for initialization
	void Start () {
        //Initialize players
        players = new Player [playerCount];
        players [0] = player1;
        gameObjects.Add (player1);
        players [1] = player2;
        gameObjects.Add (player2);
        if (playerCount > 2) {
            players [2] = player3;
            gameObjects.Add (player3);
        }
        if (playerCount > 3) {
            players [3] = player4;
            gameObjects.Add (player4);
        }
        //Initialize Terrain from Map PreFab
        foreach (Terrain obj in Arena) {
            gameObjects.Add (obj);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public ArrayList getObjectsWithin (OurGameObject origin, float radius) {
        ArrayList toReturn = new ArrayList ();

        foreach (OurGameObject obj in gameObjects) {
            if (obj.distanceTo (origin).magnitude < radius) {
                toReturn.Add (obj);
            }
        }
        return toReturn;
    }

    public void addObject (OurGameObject toAdd) {
        gameObjects.Add (toAdd);
    }

    public int getVillagerCount(){
        int sum = 0;
        foreach (OurGameObject obj in gameObjects){
            if (obj is Villager) {
                sum++;
            }
        }
        return sum;
    }

}
