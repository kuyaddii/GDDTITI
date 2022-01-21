using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESPAWN : MonoBehaviour
{
    public GameObject RECALL;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthbarscript.health == 0)
        {
            DEAD();
        }
    }
    void DEAD()
    {
        Destroy(RECALL);
    }
}
