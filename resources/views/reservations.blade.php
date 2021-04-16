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
                    <form method="POST" action="{{ route('reservations') }}">
                    @csrf

                        <!-- Billet-->
                        <div class="mt-4">
                            <x-label for="billets" :value="__('Billet')" />


                        </div>


                        <div class="flex items-center justify-end mt-4">

                            <x-button class="ml-4">
                                {{ __('Update') }}
                            </x-button>
                        </div>
                    </form>
                    <!-- Update Email -->

                </div>
            </div>
        </div>

    </div>

</x-app-layout>
