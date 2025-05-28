using UnityEngine;

namespace Shmup
{
    public class PlayerWeapon : MonoBehaviour
    {
        public GameObject weaponPrefab;
        public float speed = 5f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                Vector3 weaponLoc = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
                GameObject bullet = Instantiate(this.weaponPrefab, weaponLoc, Quaternion.identity);

                bullet.AddComponent<PlayerWeaponMove>().speed = this.speed;
            }
        }
    }
}
