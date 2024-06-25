using UnityEngine;
using UnityEngine.UI;

namespace Scritp.Chapter11
{
    public class SoundManager : MonoBehaviour
    {
        [SerializeField] protected SoundSettings m_SoundSettings;
            
             public Slider m_SliderMasterVolume;
             public Slider m_SliderBGMVolume;
             
             public Slider m_SliderSFXVolume;
             

        void Start()
        {
                 InitialiseVolumes();
        }
        
        private void InitialiseVolumes()
        {
            SetMasterVolume(m_SoundSettings.MasterVolume);
            SetBGMVolume(m_SoundSettings.BGMVolume);
            
            SetSFXVolume(m_SoundSettings.SFXVolume);
            
        }
        
        public void SetMasterVolume(float vol)
        {
             //Set float to the audiomixer
             m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.MasterVolumeName ,vol);
             //Set float to the scriptable object to persist the value although the game is closed
             m_SoundSettings.MasterVolume = vol;
            //Set the slider bar's value
            m_SliderMasterVolume.value = m_SoundSettings.MasterVolume;
        }

        public void SetBGMVolume(float vol)
        {
             //Set float to the audiomixer
             m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.BGMVolumeName ,vol);
             //Set float to the scriptable object to persist the value although the game is closed
             m_SoundSettings.BGMVolume = vol;
             //Set the slider bar's value
             m_SliderBGMVolume.value = m_SoundSettings.BGMVolume;
        }

        
         public void SetSFXVolume(float vol)
         {
         //Set float to the audiomixer
         m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.SFXVolumeName ,vol);
         //Set float to the scriptable object to persist the value although the gameis closed
         m_SoundSettings.SFXVolume = vol;
         //Set the slider bar's value
         m_SliderSFXVolume.value = m_SoundSettings.SFXVolume;
         }
     

    }
}