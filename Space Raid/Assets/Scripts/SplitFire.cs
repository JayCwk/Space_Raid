using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SplitFire")]
public class SplitFire : PowerupEffect
{
    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerWeapon>().setFire = true;
    }
}