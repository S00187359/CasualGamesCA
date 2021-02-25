using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public AttachmentButton button;
    public Transform rootChest;
    public Transform rootHead;
    public Transform rootArm;
    public Attachments attachments;

    public Animator boneAnimator;

    public Dictionary<string, GameObject> lstEqupitAttachments = new Dictionary<string, GameObject>();

    public void Start()
    {
        FillList();
    }
    public void FillList()
    {

        //InvetoryDisplay dis = Instantiate(vendorUIPrefab, rootCanvas);
        //dis.UpdateDisplay(vendorInvetory);

        foreach (var item in attachments.CharacterAttachments)
        {
            AttachmentButton currentButton = null;
            switch (item.bone)
            {

                case HumanBodyBones.Chest:
                   currentButton = Instantiate(button, rootChest);
                    break;
                case HumanBodyBones.Head:
                    currentButton = Instantiate(button, rootHead);
                    break;
                case HumanBodyBones.RightLowerArm:
                    currentButton = Instantiate(button, rootArm);
                    break;
                default:
                    break;


            }

            currentButton.transform.gameObject.name = item.ID;
            currentButton.UpdateData(item.icon, item.materialColor);
            currentButton.GetComponent<Button>().onClick.AddListener(()=> OnClickbutton(item.ID));
        }
    }

    public void OnClickbutton(string id)
    {
        var getingAttachment = attachments.GetAttachment(id);
        AddAttachment(getingAttachment);
    }

    public void AddAttachment(AttachmentData attachments)
    {
        //GameObject equiptAttachment = null;
        //lstEqupitAttachments.TryGetValue(attachments.bone.ToString(), out equiptAttachment);

        //var trasnsform = boneAnimator.GetBoneTransform(attachments.bone);

        //if (equiptAttachment == null)
        //{
        //    equiptAttachment = Instantiate(attachments.prefab, transform);
        //    lstEqupitAttachments.Add(attachments.bone.ToString(), equiptAttachment);
        //}

        //equiptAttachment.GetComponent<Renderer>().material.SetColor("_Color", attachments.materialColor);
        //equiptAttachment.GetComponent<Renderer>().material.SetTexture("_Maintex", attachments.texture);

        GameObject equiptAttachment = null;
        lstEqupitAttachments.TryGetValue(attachments.bone.ToString(), out equiptAttachment);

        // Getting Attachment Bone
        var rootTransform = boneAnimator.GetBoneTransform(attachments.bone);

        if (equiptAttachment == null)
        {
            equiptAttachment = Instantiate(attachments.prefab, rootTransform);
            lstEqupitAttachments.Add(attachments.bone.ToString(), equiptAttachment);
        }

        equiptAttachment.GetComponent<Renderer>().material.SetColor("_Color", attachments.materialColor);
        equiptAttachment.GetComponent<Renderer>().material.SetTexture("_Maintex", attachments.texture);
    }
}
