using UnityEngine;
using UnityTimer;
namespace Shmup
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] float speed = 15f;
        Rigidbody2D rigid;
        private Timer distroytime;

        public void SetSpeed(float s) => speed = s;

        void Awake()
        {
            this.rigid = GetComponent<Rigidbody2D>();
            this.distroytime = Timer.Register(10f, () => Destroy(gameObject));
        }

        public void Init(Vector3 dir)
        {
            this.rigid.linearVelocity = dir * this.speed;

            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
        }

        void Update()
        {
            transform.position += transform.forward * (this.speed * Time.deltaTime);
        }


        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Untagged"))
            {
                this.distroytime.Cancel();
                Destroy(gameObject);
            }
        }
    }
}
