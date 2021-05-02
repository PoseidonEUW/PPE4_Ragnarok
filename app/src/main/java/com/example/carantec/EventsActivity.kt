package com.example.carantec

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import com.example.carantec.ManifestationItem
import android.os.Bundle
import android.widget.Button
import android.widget.Toast
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import remote.http.EventsApi
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class EventsActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_events)

        var events = mutableListOf<ManifestationItem>()

        var adapter = EventsAdapter(events)

        findViewById<RecyclerView>(R.id.recycler_view).layoutManager = LinearLayoutManager(this)
        findViewById<RecyclerView>(R.id.recycler_view).adapter = adapter

        EventsApi().getEvents().enqueue(object: Callback<List<ManifestationItem>>{
            override fun onFailure(call: Call<List<ManifestationItem>>, t: Throwable) {
                Toast.makeText(applicationContext, t.message, Toast.LENGTH_LONG).show()
            }

            override fun onResponse(call: Call<List<ManifestationItem>>, response: Response<List<ManifestationItem>>) {

                val eventsAPI = response.body()
                eventsAPI?.let {
                    events.addAll(it.toList())
                    adapter.notifyDataSetChanged()
                }
            }
        })

        findViewById<Button>(R.id.btnRetour).setOnClickListener {
            val intent = Intent(this@EventsActivity, HomeActivity::class.java)
            startActivity(intent);
        }
    }

}