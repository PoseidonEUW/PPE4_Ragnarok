
@extends('layouts.main')

@section('content')

    <div class="relative m-auto mt-12 mb-12">
        <div class="object-fill w-full h-64 rounded-lg shadow-2x1 overflow-hidden relative">
            <img src="{{asset('images/netflix-image.jpg')}}" alt="" class="absolute inset-0 h-full w-full object-cover">
            <div class="absolute inset-0 bg-gray-900 bg-opacity-75"></div>
            <div class="flex h-full items-center justify-center relative">
                <img src="{{asset('images/Lesacteurs.png')}}" alt="">



            </div>

        </div>

    </div>
    <div class="static border-b-4 border-red-600 mb-12"></div>
    <h2 class=" cursor-default uppercase tracking-wider ml-52  text-gray-300 text-4xl font-semibold ">
        Les Artistes
    </h2>
    <div class="container mx-auto px-4 pt-16 flex-col">



                @foreach($artistes as $artiste)

                        <div class="flex flex-row mt-6 ml-3">
                            <img src="{{asset($artiste->IMGARTISTE)}}" alt="image" class="w-96 object-contain">

                            <div class="ml-32 items-center text-justify object-contain">
                                <input type="hidden" name="num" value={{$artiste->IDPERSONNE}}>
                                <div class=" text-3xl text-md-center uppercase mt-3">{{$artiste->NOMPERSONNE}} {{$artiste->PRENOMPERSONNE}} </div>
                                <div class="text-md-center text-red-600">
                                <div class="   mt-2">Rôle de l'artiste : {{$artiste->ROLEARTISTE}} </div>
                                <div class=" text-gray-300">{{$artiste->LIBELLEARTISTE}}</div>
                                <div class="mt-2"><p class=" ">Suivre l'artiste : </p> <a href="{{$artiste->LIENFBSITEARTISTE}}" class="text-gray-300 hover:text-gray-400"> {{$artiste->LIENFBSITEARTISTE}}</a></div>
                                </div>
                            </div>



                            </div>


                    @endforeach
        <div class="static border-b-4 border-red-600 mt-12 mb-12"></div>

        </div>


    {{--    </div>--}}
{{--    </div>--}}
@endsection
