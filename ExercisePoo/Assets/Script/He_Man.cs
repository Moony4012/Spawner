using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class He_Man : Heros
{
    public He_Man(string name) : base(name)
    {
        Debug.Log("Création name" + name);
    }
    public override void Attake()
    {
        Debug.Log("Wat");
    }
}
