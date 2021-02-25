using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "AttachmentData", menuName = "Attachments/Data")]
public class AttachmentData : ScriptableObject
{
    public string ID;
    public HumanBodyBones bone;
    public GameObject prefab;
    public Sprite icon;
    public Color materialColor;
    public Texture texture;
}
