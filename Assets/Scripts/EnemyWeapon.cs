using UnityEngine;
using UnityTimer;

namespace Shmup
{
    public class EnemyWeapon : MonoBehaviour
    {
        
        public float speed = 1f;
        public GameObject weaponprefab;
        public GameObject pla;

        float fireDelay = 4.0f;
        float fireTimer = 0f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            this.pla = GameObject.Find("Player");
        }

        // Update is called once per frame
        void Update()
        {
            this.fireTimer += Time.deltaTime;

            if (fireTimer > fireDelay)
            {
                Fire();
                fireTimer = 0f;
            }
        }

        void Fire()
        {
            bool isNotFound = (GameObject.Find("Player") == null);

            if (isNotFound)
            {
                return;
            }

            GameObject bullet = Instantiate(weaponprefab, transform.position, transform.rotation);
            Projectile proj = bullet.GetComponent<Projectile>();

            
            Vector3 targetPos = this.pla.transform.position;
            Vector3 dir = targetPos - transform.position;
            dir = dir.normalized;

            if (proj != null)
            {
                proj.SetSpeed(this.speed);
                proj.Init(dir);
            }
            
        }
        
    }
}
