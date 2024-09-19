using UnityEngine;

namespace WeaponMaster
{
    public class InventoryController : IInventoryController
    {
        private readonly Player _player;
        private Camera _camera = Camera.main;

        public InventoryController(Player player)
        {
            _player = player;
        }

        public void TouchScreen(Vector3 mousePosition)
        {
            Vector3 pos = _camera.ScreenToWorldPoint(mousePosition);
            var cell = UIView.InventoryGridView.Grid.GetCell(pos);
            if (cell == null)
            {
                return;
            }
            else if (cell.onFree)
            {
                if (_player.OnKeep)
                {
                    cell.PutWeapon(_player.KeepWeapon);
                    _player.PutWeapon();
                }
            }
            else if (!_player.OnKeep)
            {
                WeaponObject item = cell.GetWeapon();
                _player.TakeWeapon(item);
            }
        }
    }
}
