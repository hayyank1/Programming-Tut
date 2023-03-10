using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPick : MonoBehaviour
{
    public int RandomNumPick(int min,int max, int output)
    {
        output = Random.Range(min, max);

        return output;
    }
}
