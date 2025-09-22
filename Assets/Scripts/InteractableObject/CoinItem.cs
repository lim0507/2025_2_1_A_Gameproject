using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinItem : InteractableObject
{
    [Header("���� ����")]
    public int coinValue = 10;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        objectName = "����";
        interactionText = "[E] ���� ȹ��";
        interactionType = InteractionType.Item;
    }

    // Update is called once per frame
    protected override void CollectItem()
    {
        transform.Rotate(Vector3.up * 360f);
        Destroy(gameObject, 0.5f);
    }
}
