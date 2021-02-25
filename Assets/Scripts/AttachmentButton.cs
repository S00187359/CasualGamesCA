using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttachmentButton : MonoBehaviour
{
    public Image image;
    public Image color;

    public void UpdateData(Sprite img, Color _color)
    {
        image.sprite = img;
        color.color = _color;
    }
}
