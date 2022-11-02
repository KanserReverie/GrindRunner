using UnityEngine;

namespace GrindRunner.Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float speed = 8f;
        private CharacterController thisCharacterController;
        void Start()
        {
            thisCharacterController = GetComponentInChildren<CharacterController>();
            thisCharacterController.SimpleMove(Vector3.forward * speed);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
