﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impactEffectTimeout : MonoBehaviour
{
 public float timeout = 0.45f;
  public float createdTime;
  // Start is called before the first frame update
  void Start()
  {
    createdTime = Time.time;
  }

  // Update is called once per frame
  void Update()
  {
    if (Time.time > (createdTime + timeout) && gameObject != null)
    {
      DestroyImmediate(gameObject);
    }
  }
}