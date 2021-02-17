using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour
{
    

    public static float bottomY = 1.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
            //BombDodge apScript = Camera.main.GetComponent<BombDodge>();
            //apScript.BombDestroyed();
        }
    }
}
