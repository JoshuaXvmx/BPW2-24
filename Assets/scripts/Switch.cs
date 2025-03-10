using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject Collectable1;
    public GameObject Rune;
    public GameObject Rune1;
    public GameObject Rune2;
    public GameObject Rune3;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Rune.activeInHierarchy && Rune1.activeInHierarchy && Rune2.activeInHierarchy && Rune3.activeInHierarchy) //&& Rune2.activeInHierarchy && Rune3.activeInHierarchy)
        {
            // All game objects are active
            Collectable1.SetActive(true);
        }
    }
}
