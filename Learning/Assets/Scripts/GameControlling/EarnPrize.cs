using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarnPrize : MonoBehaviour
{
   [NonSerialized]public float prizeForDifficult;

    public int BalanceAccrual(int stars)
    {
        return Convert.ToInt32(Math.Round((double)stars*prizeForDifficult));
    }
}
