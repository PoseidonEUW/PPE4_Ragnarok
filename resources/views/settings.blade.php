<x-app-layout>
    <x-slot name="header">
        <h2 class="font-semibold text-xl text-gray-800 leading-tight">
            {{ __('Settings') }}
        </h2>
    </x-slot>

    <div class="py-12">
        <div class="max-w-7xl mx-auto sm:px-6 lg:px-8">
            <div class="bg-white overflow-hidden shadow-sm sm:rounded-lg">
                <div class="p-6 bg-white border-b border-gray-200">
                    Changer votre email !
                    <!-- Update Email -->
                    <form method="POST" action="{{ route('settings') }}">
                    @csrf

                        <!-- Email Address -->
                        <div class="mt-4">
                            <x-label for="email" :value="__('Email')" />

                            <x-input
                                :value="$user->email"
                                id="email" class="block mt-1 w-full" type="email" name="email" required></x-input>
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
