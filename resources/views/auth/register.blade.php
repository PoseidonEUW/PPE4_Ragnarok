<x-guest-layout>
    <x-auth-card>
        <x-slot name="logo">
            <a href="/">
                <x-application-logo class="w-20 h-20 fill-current text-gray-500" />
            </a>
        </x-slot>

        <!-- Validation Errors -->
        <x-auth-validation-errors class="mb-4" :errors="$errors" />

        <form method="POST" action="{{ route('register') }}">
            @csrf

            <!-- Name -->
            <div>
                <x-label for="NOMPERSONNE" :value="__('Nom')" />

                <x-input id="NOMPERSONNE" class="block mt-1 w-full" type="text" name="NOMPERSONNE" :value="old('NOMPERSONNE')" required autofocus />
            </div>

            <div>
                <x-label for="PRENOMPERSONNE" :value="__('Prénom')" />

                <x-input id="PRENOMPERSONNE" class="block mt-1 w-full" type="text" name="PRENOMPERSONNE" :value="old('PRENOMPERSONNE')" required autofocus />
            </div>

            <!-- Email Address -->
            <div class="mt-4">
                <x-label for="EMAILPERSONNE" :value="__('Email')" />

                <x-input id="EMAILPERSONNE" class="block mt-1 w-full" type="email" name="EMAILPERSONNE" :value="old('EMAILPERSONNE')" required />
            </div>

            <!-- Password -->
            <div class="mt-4">
                <x-label for="password" :value="__('Mot de passe')" />

                <x-input id="password" class="block mt-1 w-full"
                                type="password"
                                name="password"
                                required autocomplete="new-password" />
            </div>

            <!-- Confirm Password -->
            <div class="mt-4">
                <x-label for="password_confirmation" :value="__('Confirmer votre mot de passe')" />

                <x-input id="password_confirmation" class="block mt-1 w-full"
                                type="password"
                                name="password_confirmation" required />
            </div>

            <div class="flex items-center justify-end mt-4">
                <a class="underline text-sm text-gray-600 hover:text-gray-900" href="{{ route('login') }}">
                    {{ __('Déja enregistré?') }}
                </a>

                <x-button class="ml-4">
                    {{ __('S\'enregistrer')}}
                </x-button>
            </div>
        </form>
    </x-auth-card>
</x-guest-layout>
