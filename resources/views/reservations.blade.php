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
                    Verifier tes reservations
                    <!-- Billet -->
                        <!-- Billet-->
                    @foreach($reservations as $reservation)

                        <div class="flex mt-4">
                            <span>Nom de Manif : {{$reservation->LIBELLEMANIF}}</span>
                            <span class="mx-2">| </span>
                            <span>Quantiter : {{$reservation->QUANTITERESERVATION}}</span>
                        </div>
                    @endforeach

            </div>
        </div>
        </div>
    </div>

</x-app-layout>
