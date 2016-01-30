using UnityEngine;
using System.Collections;

public abstract class Item : MonoBehaviour {
    int tier;
    int typeID;

    public abstract void useItem(Player caster);
}
