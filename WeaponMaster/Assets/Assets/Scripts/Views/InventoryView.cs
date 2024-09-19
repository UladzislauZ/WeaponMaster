using UnityEngine;
using Zenject;

namespace WeaponMaster
{
    public class InventoryView : MonoBehaviour
    {
        [Inject]
        private IInventoryController _inventoryController;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                _inventoryController.TouchScreen(Input.mousePosition);
            }
        }
    }
}
