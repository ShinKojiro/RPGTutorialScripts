using UnityEngine;

public class ItemPickup : Interactable
{

    public Item item;
    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {

        Debug.Log("Picked up " + item.name);
        bool wasPickUp = Inventory.instance.Add(item);
        if (wasPickUp == true)
        {
            Destroy(gameObject);
        }
        
    }
}
