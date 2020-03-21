using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conductor : MonoBehaviour
{

  private Song song;
  private float crotchet;
  private float dspAtStart;
  private float songPosition;
  private bool songActive = false;

  public void RegisterSong(Song songToRegister)
  {
    song = songToRegister;
    crotchet = 60f / song.bpm; // frames per bpm
  }

  public void BeginSong()
  {
    dspAtStart = AudioSettings.dspTime;
    songActive = true;
  }

  private void Update()
  {
    if (!songActive)
      return;

    songPosition = (AudioSettings.dspTime - dspAtStart) * song.pitch - song.offset;
  }

}
