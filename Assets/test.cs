using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Super
{

    List<int> dataList = new List<int>();
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(dataList[i] + 10);
        }

        foreach (var data in dataList)
        {
            Debug.Log(data + 10);
        }
    }
}

public class Sub
{
}