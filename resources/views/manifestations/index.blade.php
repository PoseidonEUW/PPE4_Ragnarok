@extends('layouts.main')

@section('content')
    <div class="relative m-auto mt-12 mb-12">
        <div class="object-fill w-full h-64 rounded-lg shadow-2x1 overflow-hidden relative">
            <img src="{{asset('images/netflix-image.jpg')}}" alt="" class="absolute inset-0 h-full w-full object-cover">
            <div class="absolute inset-0 bg-gray-900 bg-opacity-75"></div>
            <div class="flex h-full items-center justify-center relative">
                <img src="{{asset('images/Prog.png')}}" alt="">



            </div>

        </div>

    </div>
    <div class="static border-b-4 border-red-600 mb-12"></div>


    <div class="container mx-auto px-4 pt-16">
        <div class="manifestations">
            <h2 class=" cursor-default uppercase tracking-wider ml-12 text-gray-300 text-3xl font-semibold">
                Les Evenements
            </h2>
            <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-3 gap-8 p-6">

                @foreach($manifestations as $manifestation)
    @if($manifestation->ANNEEFESTIVAL == 2021)
                    <div class="mt-6 ml-3 border-l-4 border-t-4 border-red-600 transition duration-5000 ease-in delay-150 transform hover:-translate-y-1 hover:scale-110 ">
                        <input type="hidden" name="num" value={{$manifestation->IDMANIF}}>
                        <a href="/manifestations/{{$manifestation->IDMANIF}}">
                            <img src="{{asset($manifestation->IMGMANIF)}}" alt="Image" class=" w-25 h-25 object-contain"></a>

                        <div class="mt-2 cursor-default ">
                            <a href="/manifestations/{{$manifestation->IDMANIF}}" class=" text-md-center uppercase mt-2 hover:text-red-600">{{$manifestation->LIBELLEMANIF}} </a>
                            <div class="flex items-center divide-x-4 divide-opacity-25 divide-red-600 text-gray-400">
                                <!-- Info -->
                                <h2 class=" ml-3 text-gray-500 ml-2"> {{$manifestation->LIBELLELIEU}} </h2>
                                @if($manifestation->PRIXMANIF != 0 || $manifestation->PRIX != NULL)
                                <p class="ml-3 text-gray-400 uppercase mx-2">
                                    Payante</p>
                            @else
                                    <p class="ml-3 text-gray-400 uppercase mx-2">
                                        Gratuite</p>
                               @endif
                                <!-- Info -->

                            </div>
                            <div class="ml-3">
                                <span>Date de Manifestation : {{$manifestation->DATEMANIF->translatedFormat('d F Y')}} à {{$manifestation->HORAIREDEBUTMANIF->translatedFormat('h:i ')}}</span>
                                @if($manifestation->concertIDMANIF != NULL)
                                    <span>Type : Concert</span>
                                @endif


                            </div>

                        </div>
                    </div>



@endif
                @endforeach
            </div>
        </div>
    </div>
@endsection
