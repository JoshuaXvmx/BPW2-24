using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Daytime;
    public GameObject Nighttime;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    private Animator Ani;
    public float delayTime = 3f;
    void Start()
    {
        Ani = GetComponent<Animator>();
       
    }
   
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        StartCoroutine(waiting());
        Daytime.SetActive(true);

        Nighttime.SetActive(false);
        IEnumerator waiting()
        {
            yield return new WaitForSeconds(3);


           obj1.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            obj4.SetActive(false);
            Destroy(gameObject);
        }

    }
}

