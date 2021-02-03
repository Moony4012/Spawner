using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jhin : Heros
{

    public Jhin(string name): base(name)
    {
        Debug.Log("Création name" + name);
    }
   
    public override void Attake()
    {
        Debug.Log("Curtain Call");
    }
}
