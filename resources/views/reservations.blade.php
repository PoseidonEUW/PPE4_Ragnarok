<x-app-layout>
    <x-slot name="header">
        <h2 class="font-semibold text-xl text-gray-800 leading-tight">
            {{ __('Mes Réservations') }}
        </h2>
    </x-slot>

    <div class="py-12">
        <div class="max-w-7xl mx-auto sm:px-6 lg:px-8">
            <div class="bg-white overflow-hidden shadow-sm sm:rounded-lg">
                <div class="p-6 bg-white border-b border-gray-200">
                    <h2 class="font-semibold text-md text-gray-800 leading-tight mb-4">Mes Reservations en Cours :</h2>
                    <!-- Billet -->


                    @foreach($reservations as $reservation)

                        <div class="flex ml-24 border-t-2 border-gray-500">
                            <span>Nom de Manif : {{$reservation->LIBELLEMANIF}}</span>
                            <span class="mx-2">| </span>
                            <span>Quantiter : {{$reservation->QUANTITERESERVATION}}</span>
                            <span class="mx-2">| </span>
                            <span>Prix : {{$reservation->PRIXMANIF}}</span>

                        </div>
                        <span class="ml-24 font-bold">Prix Total : </span>{{$reservation->PRIXMANIF*$reservation->QUANTITERESERVATION}} €

                        <!-- Billet-->




                    @endforeach


                </div>

        </div>
            <div class="bg-white overflow-hidden shadow-sm sm:rounded-lg mt-12">
                <div class="p-6 bg-white border-b border-gray-200">
                    Mes Reservations passé :

                </div>

            </div>
        </div>
    </div>

</x-app-layout>
