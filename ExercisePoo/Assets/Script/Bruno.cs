using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruno : Heros
{
    public Bruno(string name) : base(name)
    {
        Debug.Log("Création name" + name);
    }
    public override void Attake()
    {
        Debug.Log("Ari");
    }
}
