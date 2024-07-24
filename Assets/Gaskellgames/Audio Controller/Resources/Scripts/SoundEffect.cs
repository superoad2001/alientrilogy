using UnityEngine;
using UnityEngine.Audio;

/// <summary>
/// Code created by Gaskellgames
/// </summary>

namespace Gaskellgames.AudioController
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundEffect : GGMonoBehaviour
    {
        #region Variables

        private enum SoundLibrary
        {
            all,
            music,
            soundFX,
            environment,
            menuUI
        }
        
        // [Header("Audio Mixer Group"), Space]
        
        [SerializeField, RequiredField]
        private AudioMixerGroup mixerMaster;
        
        [SerializeField, RequiredField]
        private AudioMixerGroup mixerMusic;
        
        [SerializeField, RequiredField]
        private AudioMixerGroup mixerSoundFX;
        
        [SerializeField, RequiredField]
        private AudioMixerGroup mixerEnvironment;
        
        [SerializeField, RequiredField]
        private AudioMixerGroup mixerMenuUI;
        
        //[Header("References"), Space]
        
        [ReadOnly, SerializeField]
        [Tooltip("Sound manager will be set at runtime")]
        private SoundManager soundManager;
        
        [ReadOnly, SerializeField]
        [Tooltip("Sphere Collider will be set at runtime")]
        private SphereCollider sphereCollider;
        
        [ReadOnly, SerializeField]
        [Tooltip("Audio Source will be set at runtime")]
        private AudioSource audioSource;
        
        [SerializeField, RequiredField]
        private AudioMixerGroup audioMixerGroup;
        
        [SerializeField]
        private Color32 gizmoColor = new Color32(223, 179, 000, 255);

        //[Header("Sound Effect Setup"), Space]
        
        [SerializeField]
        private bool disableAfterSetup = true;
        
        [SerializeField]
        private SoundLibrary soundLibrary = SoundLibrary.environment;
        private SoundLibrary soundLibraryCheck = SoundLibrary.all;
        
        [SerializeField]
        private string soundID;
        
        #endregion

        //----------------------------------------------------------------------------------------------------

        #region Game Loop

        private void Reset()
        {
            InitialiseAudioSource();
        }

        private void Awake()
        {
            SetupAudioSource();
        }

        #endregion

        //----------------------------------------------------------------------------------------------------

#if UNITY_EDITOR

        #region Editor Gizmos

        protected override void OnDrawGizmos()
        {
            base.OnDrawGizmos();
            
            if (soundLibraryCheck != soundLibrary)
            {
                switch (soundLibrary)
                {
                    case SoundLibrary.music:
                        audioMixerGroup = mixerMusic;
                        break;
                    case SoundLibrary.soundFX:
                        audioMixerGroup = mixerSoundFX;
                        break;
                    case SoundLibrary.environment:
                        audioMixerGroup = mixerEnvironment;
                        break;
                    case SoundLibrary.menuUI:
                        audioMixerGroup = mixerMenuUI;
                        break;
                    default:
                        audioMixerGroup = mixerMaster;
                        break;
                }
                audioSource.outputAudioMixerGroup = audioMixerGroup;
                soundLibraryCheck = soundLibrary;
            }
        }

        protected override void OnDrawGizmosConditional(bool selected)
        {
            Matrix4x4 resetMatrix = Gizmos.matrix;
            Gizmos.matrix = gameObject.transform.localToWorldMatrix;

            Gizmos.color = gizmoColor;
            Gizmos.DrawWireSphere(Vector3.zero, audioSource.minDistance);
            Gizmos.DrawLine(new Vector3(audioSource.minDistance, 0, 0), new Vector3(audioSource.maxDistance, 0, 0));
            Gizmos.DrawLine(new Vector3(-audioSource.minDistance, 0, 0), new Vector3(-audioSource.maxDistance, 0, 0));
            Gizmos.DrawLine(new Vector3(0, audioSource.minDistance, 0), new Vector3(0, audioSource.maxDistance, 0));
            Gizmos.DrawLine(new Vector3(0, -audioSource.minDistance, 0), new Vector3(0, -audioSource.maxDistance, 0));
            Gizmos.DrawLine(new Vector3(0, 0, audioSource.minDistance), new Vector3(0, 0, audioSource.maxDistance));
            Gizmos.DrawLine(new Vector3(0, 0, -audioSource.minDistance), new Vector3(0, 0, -audioSource.maxDistance));
            Gizmos.DrawWireSphere(Vector3.zero, audioSource.maxDistance);

            Gizmos.matrix = resetMatrix;
        }

        #endregion

#endif
        
        //----------------------------------------------------------------------------------------------------

        #region Private Functions

        private void InitialiseAudioSource()
        {
            audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.outputAudioMixerGroup = audioMixerGroup;
            audioSource.playOnAwake = false;
            audioSource.loop = true;
            audioSource.spatialBlend = 1;
            audioSource.dopplerLevel = 0;
            audioSource.spread = 0;
            audioSource.rolloffMode = AudioRolloffMode.Custom;
            audioSource.minDistance = 1;
            audioSource.maxDistance = 50;
        }
        
        private void SetupAudioSource()
        {
            audioSource = gameObject.GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }

            soundManager = FindObjectOfType<SoundManager>();
            if (soundManager != null)
            {
                SoundData soundData;
                switch (soundLibrary)
                {
                    case SoundLibrary.music:
                        soundData = soundManager.GetSoundFromMusicID(soundID);
                        break;
                    case SoundLibrary.soundFX:
                        soundData = soundManager.GetSoundFromSoundFXID(soundID);
                        break;
                    case SoundLibrary.environment:
                        soundData = soundManager.GetSoundFromEnvironmentID(soundID);
                        break;
                    case SoundLibrary.menuUI:
                        soundData = soundManager.GetSoundFromMenuUIID(soundID);
                        break;
                    default: // soundLibrary.all
                        soundData = soundManager.GetSoundFromID(soundID);
                        break;
                }
                
                if (audioSource != null && soundData != null)
                {
                    audioSource.clip = soundData.audioClip;
                    audioSource.priority = soundData.priority;
                    audioSource.volume = soundData.volume;
                    audioSource.pitch = soundData.pitch;
                    audioSource.Play();
                }
                else
                {
                    Log("audioSource not found", LogType.Warning);
                }
            }

            if (disableAfterSetup)
            {
                gameObject.SetActive(false);
            }
        }

        #endregion
        
        //----------------------------------------------------------------------------------------------------

        #region Public Functions

        public void PlaySoundEffect()
        {
            audioSource.Play();
        }

        public string SoundID
        {
            get { return soundID; }
        }

        #endregion
        
    } // class end
}