package com.example.carantec

import android.content.Context
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.Toast

class HomeActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_home)

        findViewById<Button>(R.id.btnEvent).setOnClickListener {
            val intent = Intent(this@HomeActivity, EventsActivity::class.java)
            startActivity(intent);
        }

        findViewById<Button>(R.id.btnQuiz).setOnClickListener {
            Toast.makeText(applicationContext, "Section non disponible pour le moment", Toast.LENGTH_LONG).show()
        }

        /*btnEvent.setOnClickListener {
            // Handler code here.
            val intent = Intent(Context.CONTEXT_IGNORE_SECURITY, DestActivity::class.java)
            startActivity(intent);
        }*/
    }
}