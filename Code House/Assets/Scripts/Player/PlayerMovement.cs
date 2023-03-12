using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player {

    public class PlayerMovement : MonoBehaviour
    {
        new public Camera camera;
        public Transform target;
        private bool targetLocked;
        public CharacterController controller;
        Vector3 velocity;

        public float speed = 1f;
        public float gravity = -18f;
        public float jumpHeight = 1f;
        public Transform groundCheck;
        public float groundDistance = 0.4f;
        public LayerMask groundMask;
        bool isGrounded;

        // Update is called once per frame
        void Update() {

            if (targetLocked == false) {

                if (Input.GetKeyDown("k")) {

                    targetLocked = true;

                }
            } else if (targetLocked == true) {

                lookAtTarget();

                if (Input.GetKeyDown("k")) {
                    targetLocked = false;
                }

            }

            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0) {
                velocity.y = -2;
            }

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed  * Time.deltaTime);

            if (Input.GetButtonDown("Jump") && isGrounded) {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }

        public void lookAtTarget() {

            camera.transform.LookAt(target);

        }

    }

}
