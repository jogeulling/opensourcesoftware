using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
namespace Shmup
{
    public class player : MonoBehaviour
    {
        public Slider hpbar;
        public float maxhealth = 50f;
        public float health = 50f;
        public float bulletdamage = 10f;
        Transform model;
        SpriteRenderer spriteRenderer;

        bool end = false;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            this.hpbar.value = this.health / this.maxhealth;
            this.model = transform.Find("Model");
            this.spriteRenderer = this.GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy") || other.CompareTag("Enemybullet"))
            {
                if (gameObject.CompareTag("Untagged"))
                {
                    this.health -= this.bulletdamage;

                    this.hpbar.value = this.health / this.maxhealth;
                    OnDamaged();
                }

                if (this.health <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }

        void OnDamaged()
        {
            gameObject.tag = "Player";

            this.spriteRenderer.color = Color.red;
           
            Invoke("OffDamaged",1);
        }
        void OffDamaged()
        {
        if (this.spriteRenderer != null)
            {
                gameObject.tag = "Untagged";
                this.spriteRenderer.color = Color.white;
            }
        }
    }
}
