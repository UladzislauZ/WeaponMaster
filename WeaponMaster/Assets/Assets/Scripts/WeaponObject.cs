using UnityEngine;
using UnityEngine.UI;

namespace WeaponMaster
{
    public class WeaponObject : MonoBehaviour
    {
        [SerializeField]
        private Image _image;

        [SerializeField]
        private Image _background;

        private WeaponItemSO _weaponSO;

        [Range(1,3)]
        private int level = 1;

        public void LoadConfig(WeaponItemSO config)
        {
            _weaponSO = config;
        }

        public void LoadAssets(Sprite imageWeapon, Sprite imageBackground)
        {
            _image.sprite = imageWeapon;
            _image.sprite = imageBackground;
        }

        public string GetIdName()
        {
            return _weaponSO != null
                ? _weaponSO.nameId
                : null;
        }

        public int GetDamage()
        {
            return _weaponSO.damage * level;
        }

        public float GetReload()
        {
            return _weaponSO.reload * ((level-1) * 0.2f);
        }

        public bool TryMergeWeapon(WeaponObject weaponObject)
        {
            if (weaponObject.GetIdName() == _weaponSO.nameId && level < 3)
            {
                level++;
                weaponObject.Destroy();
                return true;
            }
            else
            { 
                return false; 
            }
        }

        public void Destroy()
        {
            Destroy(this);
        }

        public WeaponObject Clone() => (WeaponObject)MemberwiseClone();
    }
}
