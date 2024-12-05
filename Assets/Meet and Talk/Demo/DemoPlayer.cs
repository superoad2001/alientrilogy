using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using Unity.Collections;
using UnityEngine;

namespace MeetAndTalk.Demo
{
    [RequireComponent(typeof(CharacterController))]
    public class DemoPlayer : MonoBehaviour
    {
        private Controles controles;
        public void Awake()
        {
            controles = new Controles();
        }
        private void OnEnable() 
        {
            controles.Enable();
        }
        private void OnDisable() 
        {
            controles.Disable();
        }
        [Header("Movement")]
        public float walkSpeed = 6f;
        public float runSpeed = 12f;
        public float jumpPower = 7f;
        public float gravity = 10f;

        [Header("Camera")]
        public Camera playerCamera;
        public float lookSpeed = 2f;
        public float lookXLimit = 45f;

        [Header("Localization")]
        //public MeetAndTalk.Localization.LocalizationManager localizationManager;
        public TMPro.TMP_Text Lanuage;

        [Header("Interaction")]
        public float InteractionRange = 3;
        public GameObject InteractionUI;
        public TMP_Text InteractionText;

        public bool canMove = true;
        public bool Interactable;
        Vector3 moveDirection = Vector3.zero;
        float rotationX = 0;


        CharacterController characterController;
        void Start()
        {
            characterController = GetComponent<CharacterController>();
            InteractionUI.SetActive(false);
        }

        public void SetupInteractable(bool mode)
        {
            Interactable = mode;
        }

        void Update()
        {
            if (Interactable)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                #region Handles Movment
                Vector3 forward = transform.TransformDirection(Vector3.forward);
                Vector3 right = transform.TransformDirection(Vector3.right);

                // Press Left Shift to run
                bool isRunning = controles.al3.rt.ReadValue<float>() > 0;
                float curSpeedX = canMove ? (isRunning ? runSpeed : walkSpeed) * controles.al3.lvertical.ReadValue<float>() : 0;
                float curSpeedY = canMove ? (isRunning ? runSpeed : walkSpeed) * controles.al3.lhorizontal.ReadValue<float>(): 0;
                float movementDirectionY = moveDirection.y;
                moveDirection = (forward * curSpeedX) + (right * curSpeedY);

                #endregion

                #region Handles Jumping
                if (controles.al3.a.ReadValue<float>() > 0 && canMove && characterController.isGrounded)
                {
                    moveDirection.y = jumpPower;
                }
                else
                {
                    moveDirection.y = movementDirectionY;
                }

                if (!characterController.isGrounded)
                {
                    moveDirection.y -= gravity * Time.deltaTime;
                }

                #endregion

                #region Handles Rotation
                characterController.Move(moveDirection * Time.deltaTime);

                if (canMove)
                {
                    rotationX += -controles.al3.rvertical.ReadValue<float>() * lookSpeed;
                    rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
                    playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
                    transform.rotation *= Quaternion.Euler(0, controles.al3.rhorizontal.ReadValue<float>() * lookSpeed, 0);
                }

                #endregion
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }



            CastInteractionRay();

            Lanuage.text = $"Language:\n<size=64>{Localization.LocalizationManager.Instance.SelectedLang()}";
            if (controles.al3.rb.ReadValue<float>() > 0)
            {
                Localization.LocalizationManager.Instance.selectedLang = SystemLanguage.English;
            }
            if (controles.al3.lb.ReadValue<float>() > 0)
            {
                Localization.LocalizationManager.Instance.selectedLang = SystemLanguage.Polish;
            }
        }

        public void CastInteractionRay()
        {
            // Ray from the center of the camera's viewport
            Ray ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, InteractionRange))
            {
                // Check if the hit object has the Interaction script
                if (hit.collider.gameObject.GetComponent<DemoInteraction>() != null && Interactable && canMove)
                {
                    InteractionUI.SetActive(true);
                    InteractionText.text = hit.collider.gameObject.GetComponent<DemoInteraction>().InteractionText;

                    if(controles.al3.x.ReadValue<float>() > 0)
                    {
                        hit.transform.SendMessage("Interaction", SendMessageOptions.DontRequireReceiver);
                    }
                }
                else
                {
                    InteractionUI.SetActive(false);
                }
            }
            else
            {
                InteractionUI.SetActive(false);
            }
        }

        void OnDrawGizmos()
        {
            if (playerCamera != null)
            {
                // Ray from the center of the camera's viewport
                Ray ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
                Gizmos.color = Color.yellow;
                Gizmos.DrawRay(ray.origin, ray.direction * InteractionRange);
            }
        }
    }
}
