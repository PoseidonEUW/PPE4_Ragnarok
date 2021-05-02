package com.example.carantec

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide

class EventsAdapter(val events : List<ManifestationItem>) : RecyclerView.Adapter<EventsAdapter.EventViewHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): EventViewHolder {
        return EventViewHolder(
            LayoutInflater.from(parent.context)
                .inflate(R.layout.example_item, parent, false)
        )
    }

    override fun getItemCount() = events.size

    override fun onBindViewHolder(holder: EventViewHolder, position: Int) {
        val event = events[position]

        holder.view.findViewById<TextView>(R.id.textViewLibelle).text = event.LIBELLEMANIF
        holder.view.findViewById<TextView>(R.id.textViewDescription).text = event.DESCRIPTIONMANIF
        holder.view.findViewById<TextView>(R.id.textViewLieu).text = event.LIBELLELIEU
        holder.view.findViewById<TextView>(R.id.textViewDate).text = event.DATEMANIF
        holder.view.findViewById<TextView>(R.id.textViewHeure).text = event.HORAIREDEBUTMANIF

        Glide.with(holder.view.context)
            .load(event.IMGMANIF)
            .into(holder.view.findViewById<ImageView>(R.id.imageViewEvent))
    }

    class EventViewHolder(val view: View) : RecyclerView.ViewHolder(view)
}