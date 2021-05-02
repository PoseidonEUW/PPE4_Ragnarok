package remote.http

import com.example.carantec.BuildConfig
import com.example.carantec.ManifestationItem
import com.google.gson.GsonBuilder
import okhttp3.Interceptor
import okhttp3.OkHttpClient
import okhttp3.logging.HttpLoggingInterceptor
import retrofit2.Call
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import retrofit2.http.*
import java.util.concurrent.TimeUnit

const val BASE_URL = "http://192.168.164.1/APICarantec/"

/**
 * ApiService
 */
interface EventsApi {

    @GET("carantecManifAPI.php")
    fun getEvents() : Call<List<ManifestationItem>>

    companion object{
        operator fun invoke() : EventsApi{
            return Retrofit.Builder()
                .baseUrl(BASE_URL)
                .addConverterFactory(GsonConverterFactory.create())
                .build()
                .create(EventsApi::class.java)
        }
    }
}