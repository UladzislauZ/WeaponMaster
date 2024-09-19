using UnityEngine;

namespace WeaponMaster
{
    public class InventoryGridView : MonoBehaviour
    {
        public Vector2Int gridSize = new(5, 5);
        public float sizeCell;
        public RectTransform rectTransform;
        public RectTransform rectTransformShop;
        public BaseGrid Grid { get; set; }
        public BaseGrid GridShop { get; set; }

        private void Start()
        {
            UIView.InventoryGridView = this;

            if (rectTransform != null)
            {
                InitializeGrid(sizeCell);
            }
        }

        private void InitializeGrid(float sizeCell)
        {
            Grid = new BaseGrid(gridSize.x, gridSize.y, sizeCell);

            Vector2 size =
                new(
                    gridSize.x * InventorySettings.slotSize.x,
                    gridSize.y * InventorySettings.slotSize.y
                );
            rectTransform.sizeDelta = size;
        } 
    }
}
