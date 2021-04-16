
@extends('layouts.main')

@section('content')

   <div class="m-auto w-4/5 py-24">
       <div class="text-center">
           <h1 class=" cursor-default text-5xl uppercase bold">
        Festival Carantec
           </h1>
       </div>
   </div>


   <div class="container mx-auto px-4 pt-16">
       <div class="manifestations">
           <h2 class=" cursor-default uppercase tracking-wider ml-12 text-gray-300 text-3xl font-semibold">
               Les Evenements
           </h2>
           <div class="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 divide-x-4 divide-y-4 divide-red-600 gap-8 p-6">

    @foreach($manifestations as $manifestation)

                   <div class="mt-6 ml-3 transition duration-5000 ease-in delay-150 transform hover:-translate-y-1 hover:scale-110 ">
                       <input type="hidden" name="num" value={{$manifestation->IDMANIF}}>
                       <a href="/manifestations/{{$manifestation->IDMANIF}}">
                           <img src="{{asset('images/michael-discenza-MxfcoxycH_Y-unsplash.jpg')}}" alt="Image" class=" w-25 h-25">
                       </a>
                       <div class="mt-2 cursor-default ">
                           <a href="/evenement" class=" text-md-center uppercase mt-2 hover:text-red-600">{{$manifestation->LIBELLEMANIF}} </a>
                           <div class="flex items-center divide-x-4 divide-opacity-25 divide-red-600 text-gray-400">
                               <!-- Info -->
                               <h2 class="text-gray-500 ml-2"> {{$manifestation->LIBELLELIEU}} </h2>
                               <p class="ml-3 text-gray-400 mx-2">
                                    {{$manifestation->ANNEEFESTIVAL}}</p>
                               <!-- Info -->

                           </div>

                       </div>
                   </div>




@endforeach
           </div>
   </div>
        </div>
@endsection
