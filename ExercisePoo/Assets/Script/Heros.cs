using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heros : MonoBehaviour
{
    protected string _name;
    public Heros (string name)
    {
        _name = name;
        Debug.Log("Création name" + name);

    }
    
    public virtual void Attake()
    {
        Debug.Log("No Attake Detected");
    }

}
