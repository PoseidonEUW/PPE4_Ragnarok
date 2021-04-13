@extends('layouts.main')
@section('content')

    <div class="manifestation-info border-b border-gray-800 pb-8 pt-8">
        <div class="container mx-auto px4 py16 flex">
            <img src="{{asset('images/samantha-gades-fIHozNWfcvs-unsplash.jpg')}}" alt="image" class="w-96" style="width:24rem">
            <div class="ml-24">
                <h2 class="text-4xl font-semibold text-red-600">
                    {{$manifestation->LIBELLEMANIF}}
                </h2>
                <div class="flex items-center text-gray-300 text-sm mt-1">
                    <span>Date de Manifestation : {{$manifestation->DATEMANIF->translatedFormat('d F Y')}} à {{$manifestation->HORAIREDEBUTMANIF->translatedFormat('h:i ')}}H</span>
                    <span class="mx-2">|</span>
                    <span>Lieu : {{$manifestation->LIBELLELIEU}}</span>
                    <span class="mx-2">|</span>
                    <span>Prix : {{$manifestation->PRIXMANIF}}€</span>
                </div>
                <h2 class="text-xl font-semibold underline text-red-600 mb-1"> Description  </h2>
                <p class="text-gray-300">
                    {{$manifestation->DESCRIPTIONMANIF}}
                </p>
                @if (Auth::check())
                    <form class="mt-12" action="/manifestations" method="POST">
                        <div class="flex items-center">
                        <label class="mx-3" for="quantiter">Quantiter: </label>
                        <input type="number" id="quantiter" name="quantiter" min="1" max="10">
                        </div>
                        <button class="position-center bg-red-600 text-gray-300 rounded font-semibold px-5 py-4 hover:bg-red-400 transition ease-in-out duration-150" type="submit">Réserver</button>
                    </form>
                <!-- >div class="mt-12">

                        <
                </div> -->
                @endif
            </div>

        </div>


    </div>




@endsection
