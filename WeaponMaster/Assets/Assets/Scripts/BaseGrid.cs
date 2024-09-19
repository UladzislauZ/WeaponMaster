using UnityEngine;

namespace WeaponMaster
{
    public class BaseGrid
    {
        private int width;
        private int height;
        private float cellSize;
        private Cell[,] _gridCells;

        public BaseGrid(int width, int height, float cellSize)
        {
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            _gridCells = new Cell[this.width, this.height];
            CreateCells();
        }

        public void SetCell(Vector3 worldPosition, WeaponObject value)
        {
            GetXY(worldPosition, out int x, out int y);
            SetCell(x, y, value);
        }

        public Cell GetCell(Vector3 worldPosition)
        {
            GetXY(worldPosition, out int x, out int y);
            return GetCell(x, y);
        }

        private void CreateCells()
        {
            for (int i = 0; i < _gridCells.GetLength(0); i++)
            {
                for (int j = 0; j < _gridCells.GetLength(1); j++)
                {
                    _gridCells[i, j] = new();
                }
            }
        }

        private void GetXY(Vector3 position, out int x, out int y)
        {
            x = Mathf.FloorToInt(position.x);
            y = Mathf.FloorToInt(position.y);
        }

        private Cell GetCell(int x, int y)
        {
            if (x >= 0 && x < width && y >= 0 && y < height)
            {
                return _gridCells[x, y];
            }
            else
            {
                return null;
            }
        }

        private void SetCell(int x, int y, WeaponObject value)
        {
            if (x >= 0 && x < width && y >= 0 && y < height)
            {
                _gridCells[x, y].PutWeapon(value);
            }
        }

        private Vector3 GetWorldPosition(int x, int y)
        {
            return new Vector3(x, y) * cellSize;
        }
    }
}
