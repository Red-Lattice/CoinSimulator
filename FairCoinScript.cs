//Space is a furry
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairCoinScript : MonoBehaviour
{
    private bool begun = false;
    private int finalCount = 0;
    private int prevNumber = 2;

    void Start()
    {
        finalCount = 0;
        prevNumber = 2;
        begun = false;
    }

    // Update is called once per frame
    void Update()
    {
        begun = (Input.GetKeyDown(KeyCode.Space));
        if (begun)
        {
            for (int i = 0; i < 1024; i++)
            {
                if (check(i)) 
                {
                    finalCount++;
                }
                Debug.Log(finalCount);
            }
            Debug.Log(finalCount);
        }
    }
    private bool check(int initializer)
    {
        float modNum = initializer * 1.0F;

        int streak = 0;
        for (int j = 10; j > 0; j--)
        {
            //returns x to y
            if (modNum - Mathf.Pow(2, j) > 0)
            {
                if (prevNumber == 1) 
                {
                    streak++;
                } 
                else 
                {
                    streak = 1;
                }
                prevNumber = 1;
                modNum = modNum - Mathf.Pow(2, j);
            }
            else
            {
                if (prevNumber == 0) 
                {
                    streak++;
                } 
                else 
                {
                    streak = 1;
                }
                prevNumber = 0;
            }
            if (streak > 2)
            {
                return true;
            }
        }
        return false;
    }
}
