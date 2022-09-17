using UnityEngine;
using System.Collections.Generic;

public class Class : MonoBehaviour
{
    void Start()
    {
        List<BadGuy> badguys = new();

        badguys.Add(new BadGuy("Harvey", 50));
        badguys.Add(new BadGuy("Magneto", 100));
        badguys.Add(new BadGuy("Pip", 5));

        badguys.Sort();

        foreach (BadGuy guy in badguys)
        {
            print(guy.name + " " + guy.power);
        }

        badguys.Clear();
    }
}