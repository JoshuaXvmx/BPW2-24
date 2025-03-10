using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Daytime;
    public GameObject Nighttime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Daytime.SetActive(true);
        Nighttime.SetActive(false);
    }
}
