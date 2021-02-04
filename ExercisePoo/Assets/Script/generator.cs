using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator  : MonoBehaviour
{
    public List<GameObject> Bruno;
    public List<GameObject> Jhin;
    public List<GameObject> He_Man;

   void Update()
    {
        generatHeros(); 
    }

   
   private void generatHeros() 
    {
        GameObject Brunos = GetRandomHeros(Bruno);
        Instantiate(Brunos, Vector2.zero, Quaternion.identity);
        GameObject Jhins = GetRandomHeros(Jhin);
        Instantiate(Jhins, Vector2.zero, Quaternion.identity);
        GameObject He_Mans = GetRandomHeros(He_Man);
        Instantiate(He_Mans, Vector2.zero, Quaternion.identity);
    }
    GameObject GetRandomHeros(List<GameObject> partList)
    {
        int randomNumber = Random.Range(0, partList.Count);
        return partList[randomNumber];

    }

}
