
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Carantec</title>
    <link rel="stylesheet" href="/css/app.css">
    <link rel="shortcut icon" href="{{ asset('/images/vectorpaint.svg') }}">
</head>
<body class="font-sans bg-gray-900 text-white">
<div class="py-8 mb-24 md:mb-8">
    <nav class="border-b border-gray-800 bg-gray-900 fixed top-0 inset-x-0">
        <div class="container mx-auto items-center flex flex-col md:flex-row justify-between md:px4 md:py6 text-gray-300 ">
            <ul class=" flex flex-col md:flex-row items-center">
                <li>
                    <a href="/">
                        <img class="w-32 md:ml-6 object-center"src="/images/carantecred.png" alt="Carantec">
                    </a>
                </li>
                <li class="md:ml-16 transition duration-150 ease-in-out transform hover:-translate-y-1 hover:scale-110">
                    <a href="/manifestations" class="hover:text-red-600 capitalize">
                        Programmation
                    </a>
                </li>
                <li class="md:ml-6 transition duration-150 ease-in-out transform hover:-translate-y-1 hover:scale-110">
                    <a href="/artistes" class="hover:text-red-600 capitalize">
                        Artistes
                    </a>
                </li>
            </ul>
            @if (Route::has('login'))
                <div class="text-center flex md:flex-row md:px-6 md:py-4 sm:block">
                    @auth
                        <form class="text-lg md:text-sm hover:text-red-600" method="POST" action="{{ route('logout') }}">
                            @csrf
                            <a href="{{ url('/reservations') }}" class=" text-gray-300 underline hover:text-red-600 mr-4"
                            >Mon Compte</a
                            >
                            <a href="route('logout')" class="text-red-600 underline hover:text-gray-300 "
                               onclick="event.preventDefault();
                                                this.closest('form').submit();">
                                Déconnexion
                            </a>

                        </form>


                    @else
                        <a href="{{ route('login') }}" class=" text-lg md:text-sm text-gray-300 underline hover:text-red-600"
                        >Se Connecter</a
                        >

                        @if (Route::has('register'))
                            <a
                                    href="{{ route('register') }}"
                                    class="ml-4 text-lg md:text-sm text-gray-300 underline hover:text-red-600"
                            >S'inscrire</a
                            >
                        @endif
                    @endauth
                </div>
            @endif
        </div>
    </nav>
</div>
@yield('content')
{{-- Responsive--}}
<footer class="inset-x-0 bottom-0 bg-gray-800 lg:pt-2 border-b-2 border-gray-300">
    <div class="container mx-auto px-6">

        <div class="sm:flex sm:mt-8">
            <div class="lg:mt-8 sm:mt-0 sm:w-full sm:px-8 flex flex-col md:flex-row justify-between ">
                <div class="container flex flex-col text-center">
                    <img class="w-64 object-center mx-auto lg:pb-8"src="/images/carantec.png" alt="Carantec">
                    <div class="flex text-center space-x-16 mx-auto text-gray-300">
                        <li class="md:my-2"><a href="/manifestations" class="text-sm md:text-md hover:text-red-600">Programmation</a></li>
                        <li class="md:my-2"><a href="/artistes" class="text-sm md:text-md hover:text-red-600">Artistes</a></li>
                        <li class="md:my-2"><a href="https://www.ville-carantec.com/" class="text-sm md:text-md hover:text-red-600">Ville de Carantec</a></li>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container mx-auto px-6">
        <div class="mt-4 border-t-2 border-gray-300 flex flex-col items-center">
            <div class="sm:w-2/3 text-center py-6">
                <p class="text-sm text-gray-400 font-bold mb-2">
                    © 2021 Carantec
                </p>
            </div>
        </div>
    </div>
    </div>
</footer>
</body>


</html>
