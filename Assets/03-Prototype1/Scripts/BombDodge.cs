using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDodge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void BombDestroyed()
    {
        GameObject[] tBombArray = GameObject.FindGameObjectsWithTag("Bomb");
        foreach (GameObject tGO in tBombArray)
        {
            Destroy(tGO);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
