﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sprite[] thumbnails = Resources.LoadAll<Sprite>("Items");
    }
}
