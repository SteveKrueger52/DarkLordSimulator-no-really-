using UnityEngine;
using System.Collections;

public class SpawnerTerrain : WorldTerrain {
    
    int spawnCapacity = 20;
    int spawnCooldown = 100;
    float spawnRadius = 5.0f;

    [SerializeField] GameObject toSpawn;

    // Update is called once per frame
    void Update () {
        if (--spawnCooldown == 0) {
            if (world.getVillagerCount() < 20) {
                
                OurGameObject temp = this.spawn ();
                world.addObject (temp);
                spawnCooldown = 100 + Random.Range (-50, 50);
            }
        }
    }

    private OurGameObject spawn () {
        GameObject temp = Instantiate (toSpawn.gameObject);
        OurGameObject temp2 = temp.GetComponent<OurGameObject>();
        temp2.transform.localPosition = new Vector3 (
            this.transform.localPosition.x + (10f * (Random.value - .5f)),
            this.transform.localPosition.y + (10f * (Random.value - .5f)), 0f);
        return temp.GetComponent<OurGameObject>();
    }
}
