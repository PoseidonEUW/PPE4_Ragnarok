<x-app-layout>
    <x-slot name="header">
        <h2 class="font-semibold text-xl text-white leading-tight">
            {{ __('Mes Réservations') }}
        </h2>
    </x-slot>

    <div class="py-12">
        <div class="max-w-7xl mx-auto sm:px-6 lg:px-8">
            <div class="bg-white overflow-hidden shadow-sm sm:rounded-lg">
                <div class="p-6 bg-white border-b border-gray-200">
                    <h2 class="font-semibold text-md text-gray-800 leading-tight mb-4">Mes Reservations en Cours :</h2>
                 @foreach($reservations as $reservation)
                    @if($reservation->DATEMANIF < date("Y-m-d"))
                    <!-- Billet -->
                        <div class="flex ml-24 border-t-2 border-gray-500">
                            <span>Nom de Manif : {{$reservation->LIBELLEMANIF}}</span>
                            <span class="mx-2">| </span>
                            <span>Quantiter : {{$reservation->QUANTITERESERVATION}}</span>
                            <span class="mx-2">| </span>
                            <span>Prix : {{$reservation->PRIXMANIF}}</span>

                        </div>
                        <div class="flex items-center justify-end mt-4">
                    {{--                            FORM REMBOURSEMENT POUR PLUS TARD!--}}
{{--                            <form action="reservations/{{$reservation->REFRESERVATION}}" method="POST">--}}
{{--                                @csrf--}}

                            <x-button class="ml-4">
                                {{ __('Remboursement') }}
                            </x-button>
{{--                            </form>--}}
                        </div>
                        <span class="ml-24 font-bold">Prix Total : </span>{{$reservation->PRIXMANIF*$reservation->QUANTITERESERVATION}} €

                        <!-- Billet-->

                        @endif
                     @endforeach
                </div>

        </div>

            <div class="bg-white overflow-hidden shadow-sm sm:rounded-lg mt-12">
                <div class="p-6 bg-white border-b border-gray-200">
                    <h2 class="font-semibold text-md text-gray-800 leading-tight mb-4">Mes Reservations passées :</h2>
                    @foreach($reservations as $reservation)
                        @if($reservation->DATEMANIF > date("Y-m-d"))
                            <input type="hidden" name="idreservation" value="{{$reservation->IDRESERVATION}}">
                            <input type="hidden" name="idmanif" value="{{$reservation->IDMANIF}}">
                            <input type="hidden" name="idpersonne" value="{{Auth::user()->id}}">
                    <div class="flex ml-24 border-t-2 border-gray-500">
                        <span>Nom de Manif : {{$reservation->LIBELLEMANIF}}</span>
                        <span class="mx-2">| </span>
                        <span>Quantité : {{$reservation->QUANTITERESERVATION}}</span>
                        <span class="mx-2">| </span>
                        <span>Prix : {{$reservation->PRIXMANIF}}</span>


                    </div>
                            <span class="ml-24 font-bold">Prix Total : </span>{{$reservation->PRIXMANIF*$reservation->QUANTITERESERVATION}} €
                    <div class="flex items-center justify-end -pb-4">
                        <a href="/avis/{{$reservation->IDMANIF}}">
                        <x-button class="ml-4">
                            {{ __('Mettre un avis') }}
                        </x-button>

                        </a>
                    </div>

                        @endif
                    @endforeach
                </div>
            </div>
        </div>
    </div>

</x-app-layout>
