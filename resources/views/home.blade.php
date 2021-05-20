@extends('layouts.main')

@section('content')

    {{--LOGO + Fond Ecran--}}
    <div class="relative m-auto mt-12 mb-12">
        <div class="object-fill w-full h-64 rounded-lg shadow-2x1 overflow-hidden relative">
            <img src="{{asset('images/netflix-image.jpg')}}" alt="" class="absolute inset-0 h-full w-full object-cover">
            <div class="absolute inset-0 bg-gray-900 bg-opacity-75"></div>
            <div class="flex h-full items-center justify-center relative">
                <img src="{{asset('images/Cara2021.png')}}" alt="">



            </div>

        </div>

    </div>
    {{--Fin de LOGO + Fond Ecran--}}
    {{--Premier Container--}}
    {{-- Responsive--}}
    <div class="static border-b-4 border-red-600 mb-12"></div>
    <div class="container mx-auto px4 py16 lg:flex mb-12">
        <img src="{{asset('images/presentation.png')}}" alt="" class=" object-contain mx-auto lg:mx-0">
        <div class="lg:flex items-center text-center text-justify text-gray-300 text-md mt-1 lg:ml-8">
        <span>Bienvenue au Festival Carantec édtition 2021!
Venez nombreux découvrir notre splendide ville ainsi que notre incontournable festival.
            Cette année, la thématique que vous pourrez découvrir est : Films et Séries.</span>
        </div>


    </div>
    <div class="container mx-auto px4 py16 lg:flex">
        {{-- Flex Col Les Auteurs--}}
        {{-- Responsive--}}
        <div class="container mx-auto px4 py16 flex-col mb-12 lg:mb-0">
            <img src="{{asset('images/Artistes.jpg')}}" alt="" class=" object-contain h-92 w-full mb-2 ">
            <h2 class="text-4xl font-semibold text-gray-300 text-center lg:text-left border-b-2 border-red-600" >
                Les Artistes
            </h2>
            <div class="flex items-center text-justify text-gray-300 text-md text-left">
                Venez à la rencontre de vos artistes nationaux et internationaux préférés !
                Dans ce festival, tout le monde trouve son bonheur !
                Que ce soit les acteurs, les compositeurs ou bien les réalisateurs, tous sont venus pour rendre votre passage chez nous aussi merveilleux et mémorable que possible.
                Pour découvrir leurs rôles et d’autres informations les concernant, cliquez sur le bouton ci-dessous.</span>
            </div>
            <div class="lg:flex text-gray-300 text-center text-xl lg:text-md mt-1">
                <a href="/artistes" class="uppercase hover:text-red-600 ml-auto mb-8">Plus d'informations</a>
            </div>
        </div>
        {{--Flex Col Programmation --}}
        {{-- Responsive--}}
        <div class="container mx-auto px8 py16 lg:ml-48 flex-col mb-12 lg:mb-0">
            <img src="{{asset('images/Prog.jpg')}}" alt="" class=" object-contain h-60 w-full mb-4 mt-4 lg:mb-2 lg:mt-0">
            <h2 class="text-4xl font-semibold text-gray-300 text-center lg:text-left border-b-2 border-red-600" >
                La Programmation
            </h2>
            <div class="lg:flex items-center text-justify text-gray-300 text-md text-left">
                <span>Dans ce festival, vous pourrez assister à des conférences et des débats organisés par des intervenants spécialisés ; des concerts avec des chanteurs ayant prêté leur voix à la bande originale d’une œuvre ou des compositeurs ayant eux-mêmes réalisé la BO ou bien des ateliers agencés par des animateurs. Tout type d’activités vous seront proposées pour vous rapporter que du bonheur et de bons souvenirs.</span>
            </div>

            <div class="lg:flex text-gray-300 text-center text-xl lg:text-md mt-1">
                <a href="/manifestations" class="uppercase hover:text-red-600 ml-auto">Plus d'informations</a>

            </div>
        </div>
    </div>

@endsection
