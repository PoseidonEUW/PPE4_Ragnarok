@extends('layouts.main')
@section('content')
    <div class="relative m-auto mt-12 mb-12">
        <div class="object-fill w-full h-64 rounded-lg shadow-2x1 overflow-hidden relative">
            <img src="{{asset('images/netflix-image.jpg')}}" alt="" class="absolute inset-0 h-full w-full object-cover">
            <div class="absolute inset-0 bg-gray-900 bg-opacity-75"></div>
            <div class="flex h-full items-center justify-center relative">
                <img src="{{asset('images/about.png')}}" alt="">



            </div>

        </div>

    </div>
    <div class="static border-b-4 border-red-600 mb-12"></div>
    <div class="m-auto w-4/5 py-24">
        <div class="text-center">
            <h1 class=" cursor-default text-5xl uppercase bold">
                About Us
            </h1>
        </div>
    </div>
    @endsection
