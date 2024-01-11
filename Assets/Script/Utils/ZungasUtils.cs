using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ZungasUtils
{
    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale = Vector3.one * size;
    }
}
