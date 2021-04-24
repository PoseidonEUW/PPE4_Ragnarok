@extends('layouts.main')
@section('content')

    <div class="manifestation-info border-b border-gray-800 pb-8 pt-8">

        <div class="container mx-auto px4 py16 flex mb-12">
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
                    @if($manifestation->PRIXMANIF==0 || $manifestation->PRIXMANIF==NULL)
                        <span>Prix : GRATUIT</span>
                    @else
                    <span>Prix : {{$manifestation->PRIXMANIF}}€</span>
                        @endif
                </div>
                <h2 class="text-xl font-semibold underline text-red-600 mb-1"> Description  </h2>
                <p class="text-gray-300">
                    {{$manifestation->DESCRIPTIONMANIF}}
                </p>

                @if (Auth::check())
                    @if($manifestation->PRIXMANIF !=0)
                    <form class="mt-12" action="/manifestations" method="POST">
                        @csrf
                        <input type="hidden" name="idmanif" value={{$manifestation->IDMANIF}}>
                        <input type="hidden" name="idpersonne" value={{Auth::user()->id}}>
                        <div class="flex items-center">
                        <label class="mx-3" for="quantiter">Quantité : </label>
                        <input class="text-gray-600" type="number" id="quantiter" name="quantiter" min="1" max="10" value="1">
                        </div>
                        <button class="position-center mt-4 bg-red-600 text-gray-300 rounded font-semibold px-5 py-4 hover:bg-red-400 transition ease-in-out duration-150" type="submit">Réserver</button>
                    {{-- Les Messages Succés / Erreurs--}}
                        @if(session()->has('message'))
                            <div class="alert alert-success">
                                {{ session()->get('message') }}
                            </div>
                        @endif

                        {{--Fin--}}
                    </form>
                        @endif
                @else
                    <a href="{{ route('login') }}">
                        <button class="position-center mt-4 bg-red-600 text-gray-300 rounded font-semibold px-5 py-4 hover:bg-red-400 transition ease-in-out duration-150" type="submit">Réserver</button>
                    </a>
                @endif

            </div>

        </div>
        <div class="container mx-auto px4 py16 flex-col">
        <h2 class="text-5xl font-semibold text-red-600 flex-row">
            Avis
        </h2>

                @foreach($avis as $a)

                <div class="ml-24 bg-white border-b border-gray-200 rounded-lg">
                    <div class="flex items-center text-gray-800 text-sm mt-1">
                        <span class=" text-3xl text-md-center uppercase mt-3">{{$a->NOMPERSONNE}} | {{$a->PRENOMPERSONNE}}</span>
                        <span class=" text-2xl text-md-center text-red-600 uppercase mt-4 ml-4">Note : {{$a->NOTEAVIS}} </span>
                    </div>
                    <h2 class="text-xl font-semibold underline text-red-600 mb-1"> Libelle Avis  </h2>
                    <p class="text-gray-800">
                        {{$a->LIBELLEAVIS}}
                    </p>
                </div>

                @endforeach

                    {!! $avis->render() !!}

{{--Bloqué ici     --}}
            @if (Auth::check())

                    <form class="mt-12 ml-12 bg-gray-500 border-b border-gray-200 rounded-lg" action="{{route('avis.store')}}" method="POST">

                        @csrf
                        <h2 class="text-xl ml-12  font-semibold underline text-red-600 mb-1"> Mettre votre avis  </h2>
                        <input type="hidden" name="idmanif" value={{$manifestation->IDMANIF}}>
                        <input type="hidden" name="idpersonne" value={{Auth::user()->id}}>
                        <div class="flex items-center">
                        <label class="mx-3" for="noteavis">Note : </label>
{{--                        <select class="cursor-default text-gray-600" id="noteavis">--}}
{{--                            <option value="1star">1</option>--}}
{{--                            <option value="2stars">2</option>--}}
{{--                            <option value="3stars">3</option>--}}
{{--                            <option value="4stars">4</option>--}}
{{--                            <option value="5stars">5</option>--}}
{{--                        </select>--}}
                            <input class="text-gray-600" type="number" id="noteavis" name="noteavis" min="1" max="5" value="1">
                        <label class="mx-3" for="libelle">Avis : </label><br>

                            <input type="text" class="text-gray-600 ml-8" id="libelle" name="libelle" placeholder="Ici!"></div>
                            <button class="position-center mt-4 ml-8 bg-red-600 text-gray-300 rounded font-semibold px-5 py-4 hover:bg-red-400 transition ease-in-out duration-150" type="submit">Submit Avis</button>
                        {{-- Les Messages Succés / Erreurs--}}
                        @if(session()->has('message'))
                            <div class="alert alert-success">
                                {{ session()->get('message') }}
                            </div>
                        @endif

               </form>

    @endif

        </div>
    </div>




@endsection
