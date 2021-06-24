using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    GameObject[,] o = new GameObject[5, 6];
    public GameObject[,] Obj
    {
        get { return o; }
        set { o = value; }
    }
    int[,] f = new int[5, 6];
    public int[,] Field
    {
        get { return f; }
        set { f = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool CheckPos(Vector2 p1,Vector2 p2)
    {
        float x = p1.x - p2.x;
        float y = p1.y - p2.y;
        float r = Mathf.Sqrt(x * x + y * y);
        if (r < 93.75)
        {
            return true;
        }
        return false;
    }
    public void ChangePos(GameObject obj1,GameObject obj2)
    {
        DropCnt d1 = obj1.GetComponent<DropCnt>();
        DropCnt d2 = obj1.GetComponent<DropCnt>();
        GameObject tempObj;
        Vector2 tempPos;
        int temp;
        tempObj = Obj[d1.ID1, d1.ID2];
        Obj[d1.ID1, d1.ID2] = Obj[d2.ID1, d2.ID2];
        Obj[d2.ID1, d2.ID2] = tempObj;

        temp = Field [d1.ID1, d2.ID2];
        Field[d1.ID1, d1.ID2] = Field[d2.ID1, d2.ID2];
        Field[d2.ID1, d2.ID2] = temp;

        tempPos = d1.P1;
        d1.P1 = d2.P1;
        d2.P1 = tempPos;
        tempPos = d1.P2;
        d1.P2 = d2.P2;
        d2.P2 = tempPos;

        temp = d1.ID1;
        d1.ID1 = d2.ID1;
        d2.ID1 = temp;
        temp = d1.ID2;
        d1.ID2 = d2.ID2;
        d2.ID2 = temp;
    }
}
