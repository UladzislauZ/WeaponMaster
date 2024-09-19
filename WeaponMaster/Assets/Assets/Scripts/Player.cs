namespace WeaponMaster
{
    public class Player
    {
        private bool _onKeep = false;
        private WeaponObject _keepWeapon;

        public bool OnKeep => _onKeep;
        public WeaponObject KeepWeapon => _keepWeapon;

        public void TakeWeapon(WeaponObject weapon)
        {
            if (!_onKeep)
            {
                _keepWeapon = weapon;
                _onKeep = true;
            }
        }

        public WeaponObject PutWeapon()
        {
            var weaponObject = _keepWeapon.Clone();
            _keepWeapon = null;
            _onKeep = false;
            return weaponObject;
        }
    }
}
