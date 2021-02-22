using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AttachmentData
{
    public string ID;
    public HumanBodyBones bone;
    public GameObject prefab;
    public Sprite icon;
    public Color materialColor;
    public Material texture;
}
