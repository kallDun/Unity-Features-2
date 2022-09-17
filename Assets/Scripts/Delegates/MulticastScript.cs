using UnityEngine;

public class MulticastScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if (myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    void PowerUp()
    {
        print("Orb is powering up!");
    }

    void TurnRed()
    {
        foreach (var rend in GetComponentsInChildren<Renderer>(true))
        {
            rend.sharedMaterial.color = Color.yellow;
        }
    }
}