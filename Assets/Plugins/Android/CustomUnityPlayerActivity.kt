package com.unity3d.player

import android.view.KeyEvent
import com.unity3d.player.UnityPlayerActivity
import android.widget.Toast
import com.unity3d.player.UnityPlayer


class CustomUnityPlayerActivity : UnityPlayerActivity() {

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