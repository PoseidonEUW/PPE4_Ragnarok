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
<div class="static border-b-4 border-red-600 mb-12"></div>
<div class="container mx-auto px4 py16 flex mb-12">
    <img src="{{asset('images/presentation.png')}}" alt="" class=" object-contain ">
    <div class="flex items-center text-justify text-gray-300 text-md  mt-1 ml-8">
        <span>Bienvenue au Festival Carantec édtition 2021!</br>
Venez nombreux découvrir notre splendide ville ainsi que notre incontournable festival.</br>
            Cette année, la thématique que vous pourrez découvrir est : Films et Séries.</span>
    </div>


</div>
<div class="container mx-auto px4 py16  flex">
{{-- Flex Col Les Auteurs--}}
<div class="container mx-auto px4 py16 flex-col">
    <img src="{{asset('images/samantha-gades-fIHozNWfcvs-unsplash.jpg')}}" alt="" class=" object-contain h-92 w-full mb-2 ">
    <h2 class="text-4xl font-semibold text-gray-300 text-left border-b-2 border-red-600" >
        Les Artistes
    </h2>
    <div class="flex items-center text-justify text-gray-300 text-md text-left">
        Venez à la rencontre de vos artistes nationaux et internationaux préférés !
        Dans ce festival, tout le monde trouve son bonheur !
        Que ce soit les acteurs, les compositeurs ou bien les réalisateurs, tous sont venus pour rendre votre passage chez nous aussi merveilleux et mémorable que possible.
        Pour découvrir leurs rôles et d’autres informations les concernant, cliquez sur le bouton ci-dessous.</span>
    </div>
    <div class="flex text-gray-300 text-md mt-1">
        <a href="/artistes" class="uppercase hover:text-red-600 ml-auto mb-8">Plus d'informations</a>
    </div>
</div>
{{--Flex Col Programmation --}}
    <div class="container mx-auto px8 py16 ml-48 flex-col">
        <img src="{{asset('images/samantha-gades-fIHozNWfcvs-unsplash.jpg')}}" alt="" class=" object-contain h-60 w-full mb-2">
        <h2 class="text-4xl font-semibold text-gray-300 text-left border-b-2 border-red-600" >
            La Programmation
        </h2>
        <div class="flex items-center text-justify text-gray-300 text-md text-left">
        <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras cursus suscipit interdum. Nam nec libero dictum, ultrices sapien sollicitudin, congue sapien. Nam ut pharetra nibh. Etiam euismod lacus odio, rutrum sagittis mauris tempus in. Praesent imperdiet semper dui sed iaculis. Donec sed nisl in ex luctus tempor. Maecenas feugiat nec massa nec consectetur. Curabitur ipsum quam, sollicitudin non aliquet eu, tincidunt in mi. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.

Cras laoreet semper est eget efficitur. Proin vehicula posuere tempus. Fusce feugiat, ipsum et aliquam mattis, eros magna pulvinar eros, sed fringilla lectus leo at quam. Nunc fermentum magna est, et faucibus arcu efficitur eget. Aliquam ac leo risus. Vivamus ornare dictum euismod. Nunc sed ligula neque. Aliquam sodales, quam non luctus tempor, justo lectus euismod orci, ut tempor nulla enim sed augue. Donec et tincidunt enim, sed egestas dui. Sed quis ullamcorper turpis, vel laoreet tellus. Vivamus quis mi rhoncus, euismod ligula et, ornare nibh. Nulla vitae dolor aliquam, lobortis erat in, aliquam erat. Ut tempus elementum rutrum. Suspendisse vel pellentesque sem, in suscipit lorem.</span>
        </div>

        <div class="flex text-gray-300 text-md mt-1">
            <a href="/manifestations" class="uppercase hover:text-red-600 ml-auto">Plus d'informations</a>

        </div>
    </div>
</div>

@endsection
