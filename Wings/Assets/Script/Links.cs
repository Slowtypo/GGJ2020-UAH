using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void link1()
    {
        Application.OpenURL("https://twitter.com/WolfDevGames");
    }

    public void link2()
    {
        Application.OpenURL("https://www.patreon.com/thewolfdev");
    }


}
