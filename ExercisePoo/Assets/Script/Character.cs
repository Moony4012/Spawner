using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    protected StatCharacter StructInfo;
    public Character()
    {

    }
    public StatCharacter GetCharacterInfo
    {
        get { return StructInfo; }
    }

}
