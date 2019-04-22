using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptScore : MonoBehaviour
{

    private static int score=0;

    public static void addScore(int s)
    {
        score = score + s;
        Debug.Log("Placar:"+score);
    }

}
