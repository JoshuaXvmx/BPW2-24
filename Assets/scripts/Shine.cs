using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shine : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode attackKey = KeyCode.Space;
    public GameObject ShinePrefab;
    public float destroyDelay = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(attackKey))
        {
            ShinePrefab.SetActive(true);
        }
        else {
            ShinePrefab.SetActive(false);
        }
    }
      
    }
