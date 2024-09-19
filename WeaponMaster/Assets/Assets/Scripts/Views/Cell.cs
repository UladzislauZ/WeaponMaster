namespace WeaponMaster
{
    public class Cell
    {
        private WeaponObject _weaponObject;

        public bool onFree = true;

        public void PutWeapon(WeaponObject weapon)
        {
            _weaponObject = weapon;
            onFree = false;
        }

        public WeaponObject GetWeapon()
        {
            return _weaponObject;
        }

        public void ClearWeaponObject()
        {
            _weaponObject = null;
            onFree = true;
        }
    }
}
