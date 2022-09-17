using UnityEngine;
using System.Collections.Generic;

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        Dictionary<string, BadGuy> badguys = new();

        BadGuy bg1 = new("Harvey", 50);
        BadGuy bg2 = new("Magneto", 100);

        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        BadGuy magneto = badguys["mutant"];

        BadGuy temp = null;

        if (badguys.TryGetValue("birds", out temp))
        {
            Debug.Log("success!");
        }
        else
        {
            Debug.Log("failure!");
        }
    }
}