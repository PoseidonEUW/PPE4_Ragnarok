@extends('layouts.main')
@section('content')

    <div class="manifestation-info border-b border-gray-800">
        <div class="container mx-auto px4 py16 flex">
            <img src="{{asset('images/michael-discenza-MxfcoxycH_Y-unsplash.jpg')}}" alt="image" class="w-96" style="width:24rem">
            <div class="ml-24">
        {{$manifestation->LIBELLEMANIF}}
            </div>
        </div>

    </div>




@endsection
