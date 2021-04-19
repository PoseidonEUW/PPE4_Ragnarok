
@extends('layouts.main')

@section('content')

    <div class="m-auto w-4/5 py-24">
        <div class="text-center">
            <h1 class=" cursor-default text-5xl uppercase bold">
                Les Acteurs | CARANTEC 2021
            </h1>
        </div>
    </div>
    <h2 class=" cursor-default uppercase tracking-wider ml-12 text-gray-300 text-3xl font-semibold">
        Les Artistes
    </h2>
                @foreach($artistes as $artiste)

                    <div class="grid grid-rows-3 grid-flow-col gap-4 ">
                        <div class="row-span-3 ...">
                            <input type="hidden" name="num" value={{$artiste->IDPERSONNE}}>
                            <div class="/artistes/{{$artiste->IDPERSONNE}}">
                                <img src="{{asset('images/michael-discenza-MxfcoxycH_Y-unsplash.jpg')}}" alt="Image" class=" w-12 h-12" class="align-items: center";>
                            </div>
                        </div>
                        <div class="col-span-2 ...">
                            <div class=" text-3xl text-md-center uppercase mt-3">{{$artiste->NOMPERSONNE}} {{$artiste->PRENOMPERSONNE}} </div>
                            <div class=" text-md-center text-red-600  mt-2">Rôle de l'artiste : {{$artiste->ROLEARTISTE}} </div>
                            <div class="">{{$artiste->LIBELLEARTISTES}}</div>
                        </div>
                        <div class="row-span-2 col-span-2 ...">
                            <div class=" text-md-center  mt-2"><p class="text-red-600 ">Suivre l'artiste : </p>{{$artiste->LIENFBSITEARTISTE}} </div>
                        </div>

                    </div>
                @endforeach
    <h2 class=" cursor-default uppercase tracking-wider ml-12 text-gray-300 text-3xl font-semibold">
        Les Intervenants
    </h2>
    </div>
    </div>
@endsection
