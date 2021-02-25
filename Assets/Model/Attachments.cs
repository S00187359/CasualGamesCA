using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]

[CreateAssetMenu(fileName = "Attachments", menuName = "AttachmentList")]
public class Attachments : ScriptableObject
{
    public List<AttachmentData> CharacterAttachments = new List<AttachmentData>();

    public AttachmentData GetAttachment(string id)
    {
        return CharacterAttachments.Find(item => item.ID == id);
    }
}


