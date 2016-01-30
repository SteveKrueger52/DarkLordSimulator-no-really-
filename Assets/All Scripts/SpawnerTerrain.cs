using UnityEngine;
using System.Collections;

public abstract class SpawnerTerrain : WorldTerrain {
    
    int spawnCapacity = 20;
    int spawnCooldown = 100;
    float spawnRadius = 5.0f;

    // Update is called once per frame
    void Update () {
        if (--spawnCooldown == 0) {
            if (world.getObjectsWithin (this, spawnRadius).Count < 20) {
                
                OurGameObject temp = this.spawn ();
                world.addObject (temp);
                spawnCooldown = 100 + Random.Range (-50, 50);
            }
        }
    }

    abstract OurGameObject spawn ();
}
