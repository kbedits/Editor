﻿using UnityEngine;

namespace Rust.Ai
{
    [ExecuteAlways]
    public class AiLocationManager : MonoBehaviour
    {
        protected void Awake()
        {
            DestroyImmediate(this);
        }
    }
}