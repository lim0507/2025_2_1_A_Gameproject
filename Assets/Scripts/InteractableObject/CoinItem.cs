using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinItem : InteractableObject
{
    [Header("µ¿Àü ¼³Á¤")]
    public int coinValue = 10;
    public string questTag = "Coin";

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        objectName = "µ¿Àü";
        interactionText = "[E] µ¿Àü È¹µæ";
        interactionType = InteractionType.Item;
    }

    // Update is called once per frame
    protected override void CollectItem()
    {
        if(QuestManager.Instance != null)
        {
            QuestManager.Instance.AddCollectProgress(questTag);
        }

        transform.Rotate(Vector3.up * 360f);
        Destroy(gameObject, 0.5f);
    }
}
