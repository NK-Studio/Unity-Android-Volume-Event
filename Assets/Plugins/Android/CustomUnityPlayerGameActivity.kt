package com.unity3d.player

import android.view.KeyEvent

class CustomUnityPlayerGameActivity : UnityPlayerGameActivity()
{


    override fun onKeyDown(keyCode: Int, p1: KeyEvent?): Boolean {

        when (keyCode) {
            KeyEvent.KEYCODE_VOLUME_UP -> {
                UnityPlayer.UnitySendMessage("AndroidPlugin","VolumeEvent","Up")
                return true
            }
            KeyEvent.KEYCODE_VOLUME_DOWN -> {
                UnityPlayer.UnitySendMessage("AndroidPlugin","VolumeEvent","Down")
                return true
            }
        }
        return true
    }


}