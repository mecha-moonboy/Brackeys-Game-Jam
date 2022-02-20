using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanity : MonoBehaviour
{

    public int maxSanity = 1000000;
    public int currentSanity;

    public SanityBar sanityBar;

    // Start is called before the first frame update
    void Start()
    {
        
        currentSanity = maxSanity;
        sanityBar.SetMaxSanity(maxSanity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
            loseSanity(1);

    }

    void loseSanity (int damage)
    {

        currentSanity -= damage;

        sanityBar.SetSanity(currentSanity);

    }
}
