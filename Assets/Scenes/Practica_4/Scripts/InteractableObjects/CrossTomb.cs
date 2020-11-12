
using UnityEngine;



namespace P4
{
    public class CrossTomb : P4.Interactable
    {
        private Rigidbody _rigidbody; 
        public Vector3 forceDirection;
        public float force;


        private bool keyM, keyO, keyV, keyE;
        // Start is called before the first frame update
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            if (IsInsideZone)
            {
                if (Input.GetKeyDown(KeyCode.M))
                    keyM = true;
                if (Input.GetKeyDown(KeyCode.O))
                    keyO = true;
                if (Input.GetKeyDown(KeyCode.V))
                    keyV = true;
                if (Input.GetKeyDown(KeyCode.E))
                    keyE = true;

                if (keyM && keyO && keyV && keyE)
                {
                    
                    _rigidbody.AddForce(forceDirection * force, ForceMode.Force);
                   
                }

            }

        }

        protected override void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                keyM = false;
                keyO = false;
                keyV = false;
                keyE = false;
            }
        }
    }
    
}

