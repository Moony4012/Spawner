using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjects : MonoBehaviour
{
    void Start()
    {
        Character currentCharacter = new Jhin();
        Debug.Log(currentCharacter.GetCharacterInfo.name);
        Debug.Log(currentCharacter.GetCharacterInfo.vie);
    }
}
