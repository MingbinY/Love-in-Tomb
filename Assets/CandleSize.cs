using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleSize : MonoBehaviour
{
    public float minSize;
    public float maxSize;
    public float defaultSize;

    private void Start()
    {
        float a = Random.Range(minSize, maxSize);
        bool changeAll = Random.Range(0, 1) <= 0.8f;

        if (changeAll)
        {
            transform.localScale = new Vector3(a, a, a);
        }
        else
        {
            transform.localScale = new Vector3(defaultSize, defaultSize, a);
        }
    }
}
