
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width-device-width, initial-scale-1">
    <title>Carantec</title>
    <link rel="stylesheet" href="/css/app.css">
    <link rel="shortcut icon" href="{{ asset('/images/vectorpaint.svg') }}">
</head>
<body class="font-sans bg-gray-900 text-white">
<div class="py-8">
<nav class="border-b border-gray-800 fixed top-0 inset-x-0">
    <div class="container mix-auto items-center justify-between px4 py6 text-gray-300 ">
        <ul class=" flex items-center">

            <li>

                <a href="/">

                    <img class="w-32 ml-6 object-center"src="/images/carantecred.png" alt="Carantec">

                </a>
            </li>
            <li class="md:ml-16 mt-3 md:mt-0 ">
                <a href="/manifestations" class="hover:text-red-600 capitalize">
                    Programmation
                </a>
            </li>
            <li class="md:ml-6 mt-3 md:mt-0  ">
                <a href="#" class="hover:text-red-600 capitalize">
                    Activités
                </a>
            </li>
            <li class="md:ml-6 mt-3 md:mt-0 ">
                <a href="/about-us" class="hover:text-red-600 capitalize">
                    Qui sommes nous?
                </a>
            </li>
        </ul>
            @if (Route::has('login'))
                <div class="hidden fixed top-0 right-0 px-6 py-4 sm:block">
                    @auth
                        <a href="{{ url('/dashboard') }}" class="text-sm text-gray-300 underline hover:text-red-600"
                        >Dashboard</a
                        >
                    @else
                        <a href="{{ route('login') }}" class="text-sm text-gray-300 underline hover:text-red-600"
                        >Se Connecter</a
                        >

                        @if (Route::has('register'))
                            <a
                                href="{{ route('register') }}"
                                class="ml-4 text-sm text-gray-300 underline hover:text-red-600"
                            >S'inscrire</a
                            >
                        @endif
                    @endauth

            @endif
                </div>
</nav>
</div>
@yield('content')

<footer class="fixed bottom-0 inset-y-0 bg-gray-800 relative pt-1 border-b-2 border-gray-300">
    <div class="container mx-auto px-6">

        <div class="sm:flex sm:mt-8">
            <div class="mt-8 sm:mt-0 sm:w-full sm:px-8 flex flex-col md:flex-row justify-between ">
                <div class="container flex flex-col text-left">
                    <span class="font-bold text-gray-400 uppercase mb-2 ">Footer header 1</span>
                    <span class="my-2"><a href="#" class="text-blue-700  text-md hover:text-blue-500">link 1</a></span>
                    <span class="my-2"><a href="#" class="text-blue-700  text-md hover:text-blue-500">link 1</a></span>
                    <span class="my-2"><a href="#" class="text-blue-700  text-md hover:text-blue-500">link 1</a></span>
                </div>
                <div class="container flex flex-col text-center">
                    <span class="font-bold text-gray-400 uppercase mt-4 md:mt-0 mb-2 ">Footer header 2</span>
                    <span class="my-2"><a href="#" class="text-blue-700 text-md hover:text-blue-500">link 1</a></span>
                    <span class="my-2"><a href="#" class="text-blue-700  text-md hover:text-blue-500">link 1</a></span>
                    <span class="my-2"><a href="#" class="text-blue-700 text-md hover:text-blue-500">link 1</a></span>
                </div>
                <div class="container flex flex-col text-right">
                    <span class="font-bold text-gray-400 uppercase mt-4 md:mt-0 mb-2">Footer header 3</span>

                    <span class="my-2"><a href="#" class="text-blue-700  text-md hover:text-blue-500">link 1</a></span>
                    <span class="my-2"><a href="#" class="text-blue-700  text-md hover:text-blue-500">link 1</a></span>
                    <span class="my-2"><a href="#" class="text-blue-700  text-md hover:text-blue-500">link 1</a></span>

                    </div>
            </div>
        </div>
    </div>
    <div class="container mx-auto px-6">
        <div class="mt-16  border-t-2 border-gray-300 flex flex-col items-center">
            <div class="sm:w-2/3 text-center py-6">
                <p class="text-sm text-gray-400 font-bold mb-2">
                    © 2021 Carantec
                </p>
            </div>
        </div>
    </div>
</footer>
</body>


</html>
