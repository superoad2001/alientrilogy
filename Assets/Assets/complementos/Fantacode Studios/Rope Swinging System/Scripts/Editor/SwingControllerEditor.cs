using UnityEditor;
using UnityEngine;

namespace FS_SwingSystem
{

    [CustomEditor(typeof(SwingController))]
    public class SwingControllerEditor : Editor
    {
        private SerializedProperty swingWithoutEquip;
        private SerializedProperty unEquipAfterSwing;
        private SerializedProperty minDistanceProp;
        private SerializedProperty hookInputProp;
        private SerializedProperty hookReleaseInput;
        private SerializedProperty ropeClimbModifier;
        private SerializedProperty hookInputButton;
        private SerializedProperty hookReleaseInputButton;
        private SerializedProperty ropeClimbModifierButton;
        //private SerializedProperty ropeThrowingClipProp;
        //private SerializedProperty hookHoldingClip;
        //private SerializedProperty equippingClip;
        //private SerializedProperty holdingClip;
        //private SerializedProperty handMask;
        //private SerializedProperty animationSpeedProp;

        // Rope properties
        private SerializedProperty ropeHoldTransformRightProp;
        private SerializedProperty ropeHoldTransformLeftProp;
        private SerializedProperty ropeAttachTransformInBodyProp;
        private SerializedProperty ropeRadiusProp;
        private SerializedProperty ropeMaterialProp;
        private SerializedProperty ropeResolutionProp;
        private SerializedProperty ropeLengthProp;
        private SerializedProperty ropeWidthProp;
        private SerializedProperty dampeningProp;
        //private SerializedProperty smoothingFactorProp;
        private SerializedProperty throwHeightProp;
        private SerializedProperty throwDurationProp;

        // Swing properties
        private SerializedProperty swingForceProp;
        private SerializedProperty swingRotationSpeed;
        private SerializedProperty climbSpeed;
        //private SerializedProperty climbDownSpeed;
        private SerializedProperty forwardLandForceMultiplier;
        private SerializedProperty upwardLandForceMultiplier;
        private SerializedProperty dampingProp;
        private SerializedProperty gravityProp;
        //private SerializedProperty maxSwingAngleProp;
        //private SerializedProperty softConstraintStrengthProp;
        //private SerializedProperty additionalDampingNearMaxAngleProp;
        private SerializedProperty collisionFrictionProp;

        SerializedProperty cameraShakeAmount;
        SerializedProperty cameraShakeDuration;

        private SerializedProperty crosshairPrefabProp;
        private SerializedProperty crosshairSizeProp;

        // Events
        private SerializedProperty RopeReleasedProp;
        private SerializedProperty RopeHookedProp;
        private SerializedProperty SwingStartedProp;
        private SerializedProperty ExitedFromSwingProp;

        // Toolbar setup
        private string[] toolbarOptions1 = new string[] { "General", "Input", "Swing" };
        private string[] toolbarOptions2 = new string[] { "Rope", "Camera Settings", "Crosshair" };
        private string[] toolbarOptions3 = new string[] { "Events" };

        int selectedToolbarIndex = 0;

        private void OnEnable()
        {
            // General settings
            swingWithoutEquip = serializedObject.FindProperty("swingWithoutEquip");
            unEquipAfterSwing = serializedObject.FindProperty("unEquipAfterSwing");
            minDistanceProp = serializedObject.FindProperty("minDistance");

            hookInputProp = serializedObject.FindProperty("hookInput");
            hookReleaseInput = serializedObject.FindProperty("hookReleaseInput");
            ropeClimbModifier = serializedObject.FindProperty("ropeClimbModifier");

            hookInputButton = serializedObject.FindProperty("hookInputButton");
            hookReleaseInputButton = serializedObject.FindProperty("hookReleaseInputButton");
            ropeClimbModifierButton = serializedObject.FindProperty("ropeClimbModifierButton");

            //ropeThrowingClipProp = serializedObject.FindProperty("ropeThrowingClip");
            //hookHoldingClip = serializedObject.FindProperty("hookHoldingClip");
            //equippingClip = serializedObject.FindProperty("equippingClip");
            //holdingClip = serializedObject.FindProperty("holdingClip");
            //handMask = serializedObject.FindProperty("handMask");
            //animationSpeedProp = serializedObject.FindProperty("animationSpeed");

            // Rope settings
            ropeHoldTransformRightProp = serializedObject.FindProperty("ropeHoldTransformRight");
            ropeHoldTransformLeftProp = serializedObject.FindProperty("ropeHoldTransformLeft");
            ropeAttachTransformInBodyProp = serializedObject.FindProperty("ropeAttachTransformInBody");
            ropeRadiusProp = serializedObject.FindProperty("ropeRadius");
            ropeMaterialProp = serializedObject.FindProperty("ropeMaterial");
            ropeResolutionProp = serializedObject.FindProperty("ropeResolution");
            ropeLengthProp = serializedObject.FindProperty("ropeLength");
            ropeWidthProp = serializedObject.FindProperty("ropeWidth");
            dampeningProp = serializedObject.FindProperty("dampening");
            //smoothingFactorProp = serializedObject.FindProperty("smoothingFactor");
            throwHeightProp = serializedObject.FindProperty("throwHeight");
            throwDurationProp = serializedObject.FindProperty("throwDuration");

            //camera
            cameraShakeAmount = serializedObject.FindProperty("cameraShakeAmount");
            cameraShakeDuration = serializedObject.FindProperty("cameraShakeDuration");

            // Swing settings
            swingForceProp = serializedObject.FindProperty("swingForce");
            swingRotationSpeed = serializedObject.FindProperty("swingRotationSpeed");
            //climbDownSpeed = serializedObject.FindProperty("climbDownSpeed");
            climbSpeed = serializedObject.FindProperty("climbSpeed");
            forwardLandForceMultiplier = serializedObject.FindProperty("forwardLandForceMultiplier");
            upwardLandForceMultiplier = serializedObject.FindProperty("upwardLandForceMultiplier");
            dampingProp = serializedObject.FindProperty("damping");
            gravityProp = serializedObject.FindProperty("gravity");
            //maxSwingAngleProp = serializedObject.FindProperty("maxSwingAngle");
            //softConstraintStrengthProp = serializedObject.FindProperty("softConstraintStrength");
            //additionalDampingNearMaxAngleProp = serializedObject.FindProperty("additionalDampingNearMaxAngle");
            collisionFrictionProp = serializedObject.FindProperty("collisionFriction");

            // Crosshair settings
            crosshairPrefabProp = serializedObject.FindProperty("crosshairPrefab");
            crosshairSizeProp = serializedObject.FindProperty("crosshairSize");

            // Events
            RopeReleasedProp = serializedObject.FindProperty("RopeReleased");
            RopeHookedProp = serializedObject.FindProperty("RopeHooked");
            SwingStartedProp = serializedObject.FindProperty("SwingStarted");
            ExitedFromSwingProp = serializedObject.FindProperty("ExitedFromSwing");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            selectedToolbarIndex = GUILayout.Toolbar(selectedToolbarIndex, toolbarOptions1, GUILayout.Height(25));
            selectedToolbarIndex = GUILayout.Toolbar(selectedToolbarIndex - toolbarOptions1.Length, toolbarOptions2, GUILayout.Height(25)) + toolbarOptions1.Length;
            selectedToolbarIndex = GUILayout.Toolbar(selectedToolbarIndex - toolbarOptions2.Length - toolbarOptions1.Length, toolbarOptions3, GUILayout.Height(25)) + toolbarOptions2.Length + toolbarOptions1.Length;

            switch (selectedToolbarIndex)
            {
                case 0: // General
                    DrawGeneralSettings();
                    break;

                case 1: // Input
                    EditorGUILayout.Space();
                    DrawInputSettings();
                    break;

                case 2: // Swing
                    EditorGUILayout.Space();
                    DrawSwingSettings();
                    break;

                case 3: // Rope
                    EditorGUILayout.Space();
                    DrawRopeSettings();
                    break;

                case 4: //Camera Settings
                    EditorGUILayout.Space();
                    DrawCameraSettings();
                    break;

                case 5: // Crosshair Settings
                    EditorGUILayout.Space();
                    DrawCrosshairSettings();
                    break;

                case 6: // Events
                    EditorGUILayout.Space();
                    DrawEvents();
                    break;
            }

            serializedObject.ApplyModifiedProperties();
        }

        private void DrawGeneralSettings()
        {
            EditorGUILayout.PropertyField(swingWithoutEquip);
            if (swingWithoutEquip.boolValue)
                EditorGUILayout.PropertyField(unEquipAfterSwing);
            EditorGUILayout.PropertyField(minDistanceProp, new GUIContent("Min Distance"));
            //EditorGUILayout.PropertyField(ropeThrowingClipProp, new GUIContent("Rope Throwing Clip"));
            //EditorGUILayout.PropertyField(animationSpeedmoProp, new GUIContent("Animation Speed"));
            //EditorGUILayout.PropertyField(hookHoldingClip);
            //EditorGUILayout.PropertyField(equippingClip);
            //EditorGUILayout.PropertyField(holdingClip);
            //EditorGUILayout.PropertyField(handMask);
        }

        private void DrawInputSettings()
        {
            EditorGUILayout.PropertyField(hookInputProp);
            EditorGUILayout.PropertyField(hookReleaseInput);
            EditorGUILayout.PropertyField(ropeClimbModifier);

            GUILayout.Space(10);

            EditorGUILayout.PropertyField(hookInputButton);
            EditorGUILayout.PropertyField(hookReleaseInputButton);
            EditorGUILayout.PropertyField(ropeClimbModifierButton);
        }

        private void DrawRopeSettings()
        {
            //EditorGUILayout.LabelField("Rope Settings", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(ropeHoldTransformRightProp, new GUIContent("Right Hold Transform"));
            EditorGUILayout.PropertyField(ropeHoldTransformLeftProp, new GUIContent("Left Hold Transform"));
            EditorGUILayout.PropertyField(ropeAttachTransformInBodyProp, new GUIContent("Attach Transform"));
            EditorGUILayout.PropertyField(ropeRadiusProp, new GUIContent("Rope Radius"));
            EditorGUILayout.PropertyField(ropeMaterialProp, new GUIContent("Rope Material"));
            EditorGUILayout.PropertyField(ropeResolutionProp, new GUIContent("Rope Resolution"));
            EditorGUILayout.PropertyField(ropeLengthProp, new GUIContent("Rope Length"));
            EditorGUILayout.PropertyField(ropeWidthProp, new GUIContent("Rope Width"));
            EditorGUILayout.PropertyField(dampeningProp, new GUIContent("Dampening"));
            //EditorGUILayout.PropertyField(smoothingFactorProp, new GUIContent("Smoothing Factor"));
            EditorGUILayout.PropertyField(throwHeightProp, new GUIContent("Throw Height"));
            EditorGUILayout.PropertyField(throwDurationProp, new GUIContent("Throw Duration"));
        }

        private void DrawSwingSettings()
        {
            //EditorGUILayout.LabelField("Swing Settings", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(swingForceProp, new GUIContent("Swing Force"));
            EditorGUILayout.PropertyField(swingRotationSpeed, new GUIContent("Rotation Speed"));
            EditorGUILayout.PropertyField(climbSpeed);
            //EditorGUILayout.PropertyField(climbDownSpeed);
            EditorGUILayout.PropertyField(forwardLandForceMultiplier);
            EditorGUILayout.PropertyField(upwardLandForceMultiplier);
            EditorGUILayout.PropertyField(dampingProp, new GUIContent("Damping"));
            EditorGUILayout.PropertyField(gravityProp, new GUIContent("Gravity"));
            //EditorGUILayout.PropertyField(maxSwingAngleProp, new GUIContent("Max Swing Angle"));
            //EditorGUILayout.PropertyField(softConstraintStrengthProp, new GUIContent("Soft Constraint Strength"));
            //EditorGUILayout.PropertyField(additionalDampingNearMaxAngleProp, new GUIContent("Additional Damping Near Max Angle"));
            EditorGUILayout.PropertyField(collisionFrictionProp, new GUIContent("Collision Friction"));
        }

        private void DrawCameraSettings()
        {
            EditorGUILayout.PropertyField(cameraShakeAmount, new GUIContent("Shake Amount", "The intensity of the camera shake when the hook is pulled."));
            EditorGUILayout.PropertyField(cameraShakeDuration, new GUIContent("Shake Duration", "The duration of the camera shake when the hook is pulled."));
        }

        private void DrawCrosshairSettings()
        {
            EditorGUILayout.PropertyField(crosshairPrefabProp, new GUIContent("Crosshair Prefab"));
            EditorGUILayout.PropertyField(crosshairSizeProp, new GUIContent("Crosshair Size"));
        }

        private void DrawEvents()
        {
            EditorGUILayout.PropertyField(RopeReleasedProp, new GUIContent("Rope Released Event"));
            EditorGUILayout.PropertyField(RopeHookedProp, new GUIContent("Rope Hooked Event"));
            EditorGUILayout.PropertyField(SwingStartedProp, new GUIContent("Swing Started Event"));
            EditorGUILayout.PropertyField(ExitedFromSwingProp, new GUIContent("Exited From Swing Event"));
        }
    }
}