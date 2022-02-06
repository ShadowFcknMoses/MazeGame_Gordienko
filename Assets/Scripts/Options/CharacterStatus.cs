using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Character/status")]
public class CharacterStatus : ScriptableObject
{
    // Start is called before the first frame update
    public bool isAiming;
    public bool isSprint;
    public bool isGround;
}
