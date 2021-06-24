using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCnt : MonoBehaviour
{
    [SerializeField] Sprite[] sp;
    public int ID1
    {
        get;
        set;
    }
    public int ID2
    {
        get;
        set;
    }
    bool touchFlag;
    Vector2 m;
    RectTransform r, r2;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<RectTransform>();
        r2 = transform.parent.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (touchFlag)
        {
            var pos = Vector2.zero;
            m = Input.mousePosition;
            RectTransformUtility.ScreenPointToLocalPointInRectangle
                (r2, m, Camera.main,out pos);
            r.localPosition = pos;
        }
    }
    public void Set(int n)
    {
        GetComponent<SpriteRenderer>().sprite = sp[n];
    }
    public void GetDrop()
    {
        touchFlag = true;
    }
    public void SetDrop()
    {
        touchFlag = false;
    }
}
