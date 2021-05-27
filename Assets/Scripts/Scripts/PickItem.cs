using System.Collections;
using System.Collections.Generic;
using Items;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    [SerializeField]
    private ItemBase _itemBase;
    private PlayerCreature playerCreature;
    [SerializeField]
    protected float radius;
    protected Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<MoveOnClick>().transform;
        playerCreature = player.gameObject.GetComponent<PlayerCreature>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= radius)
        {
            Item item = new Equipment(_itemBase as EquipmentBase);
            playerCreature.PlayerInventoryController.AddItemToInventory(item);
            item.SetOwner(playerCreature);
            Destroy(gameObject);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
