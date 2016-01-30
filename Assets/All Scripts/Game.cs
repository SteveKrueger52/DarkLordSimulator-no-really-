using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    ArrayList gameObjects;

	// Use this for initialization
	void Start () {
	
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
        foreach (Villager v in gameObjects){
            sum += 1;
        }
        return sum;
    }

}
