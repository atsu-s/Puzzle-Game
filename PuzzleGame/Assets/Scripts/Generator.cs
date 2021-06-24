using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject D, L;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            GameObject l = Instantiate(L) as GameObject;
            l.transform.SetParent(transform);
            l.transform.localScale = Vector3.one;
            for (int j = 0; j < 6; j++)
            {
                GameObject d = Instantiate(D) as GameObject;
                d.transform.SetParent(l.transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
