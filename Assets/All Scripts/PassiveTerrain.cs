using UnityEngine;
using System.Collections;

public class PassiveTerrain : WorldTerrain {

    [SerializeField] bool lethal; // will minions die if they touch this?

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        foreach (NonPlayerCharacter m in world.getObjectsWithin(this, 0.5f)) {
            if (m is Minion && ((Minion)m).canSacrifice()) {
                ((Minion)m).Sacrifice (); 
            }
            if (lethal) {
                m.die ();
            }
        }
    }
}
