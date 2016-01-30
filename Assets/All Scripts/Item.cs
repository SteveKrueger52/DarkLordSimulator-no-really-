using UnityEngine;
using System.Collections;

public abstract class Item : MonoBehaviour {
    int tier;
    int typeID;

    public abstract void activateItem (Player caster);
}
