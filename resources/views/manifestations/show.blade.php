@extends('layouts.main')
@section('content')

    <div class="manifestation-info border-b border-gray-800 pb-8 pt-8">
        <div class="container mx-auto px4 py16 flex">
            <img src="{{asset('images/samantha-gades-fIHozNWfcvs-unsplash.jpg')}}" alt="image" class="w-96" style="width:24rem">
            <div class="ml-24">
                <h2 class="text-4xl font-semibold">
                    {{$manifestation->LIBELLEMANIF}}
                </h2>
                <div class="flex items-center text-gray-400 text-sm mt-1">
                    <span>Date de Manifestation : {{$manifestation->DATEMANIF}}</span>
                    <span class="mx-2">|</span>
                    <span>Horaire : {{$manifestation->HORAIREDEBUTMANIF}}</span>
                </div>
                <p class="text-gray-300 mt-8">
                    {{$manifestation->DESCRIPTIONMANIF}}
                </p>
            </div>

        </div>

    </div>




@endsection
