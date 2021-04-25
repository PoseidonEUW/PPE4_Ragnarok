
@extends('layouts.main')

@section('content')

    <div class="m-auto w-4/5 pb-4 pt-24">
        <div class="text-center">
            <h1 class=" cursor-default text-5xl uppercase bold">
                Les Acteurs | CARANTEC 2021
            </h1>
        </div>
    </div>

    <div class="container mx-auto px-4 pt-16 flex-col">
        <h2 class=" cursor-default uppercase tracking-wider ml-12 text-gray-300 text-4xl font-semibold underline">
            Les Artistes
        </h2>


                @foreach($artistes as $artiste)

                        <div class="flex flex-row mt-6 ml-3">
                            <div class="ImageInfo">
                            <input type="hidden" name="num" value={{$artiste->IDPERSONNE}}>
                            <a href="/artistes/{{$artiste->IDPERSONNE}}">
                                <img src="{{asset('images/samantha-gades-fIHozNWfcvs-unsplash.jpg')}}" alt="image" class="w-96" style="width:24rem">
                            </a>
                            </div>
                            <div class="ml-24">
                                <div class=" text-3xl text-md-center uppercase mt-3">{{$artiste->NOMPERSONNE}} {{$artiste->PRENOMPERSONNE}} </div>
                                <div class=" text-md-center text-red-600  mt-2">Rôle de l'artiste : {{$artiste->ROLEARTISTE}} </div>
                                <div class="">{{$artiste->LIBELLEARTISTES}}</div>
                                <div class=" text-md-center  mt-2"><p class="text-red-600 ">Suivre l'artiste : </p>{{$artiste->LIENFBSITEARTISTE}} </div>
                            </div>



                            </div>


                    @endforeach
                        <h2 class=" cursor-default uppercase tracking-wider text-gray-300 text-3xl font-semibold">
                            Les Intervenants
                        </h2>
        </div>


    {{--    </div>--}}
{{--    </div>--}}
@endsection
