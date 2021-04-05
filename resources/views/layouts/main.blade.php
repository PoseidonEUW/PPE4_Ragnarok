
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
<nav class=" border-b border-gray-800">
<div class="container mix-auto  fixed items-center justify-between px4 py6 text-red-600 ">
    <ul class=" flex items-center">

        <li>

            <a href="#">

                <img class="w-32 ml-6 object-center"src="/images/carantecred.png" alt="Carantec">

            </a>
        </li>
        <li class="md:ml-16 mt-3 md:mt-0 ">
            <a href="#" class="hover:text-gray-300 capitalize">
                Page 1
            </a>
        </li>
        <li class="md:ml-6 mt-3 md:mt-0  ">
            <a href="#" class="hover:text-gray-300 capitalize">
                Page 2
            </a>
        </li>
        <li class="md:ml-6 mt-3 md:mt-0 ">
            <a href="#" class="hover:text-gray-300 capitalize">
                Page 3
            </a>
        </li>
    </ul>
   <!-- Bar de Recherche
     <div class="flex items-center">
        <div class="pt-2 relative mx-auto text-gray-300">
            <input type="search" class="border-2 border-gray-300 bg-gray-800 h-10 px-5 pr-28 rounded-lg text-sm focus:outline-none" placeholder="Rechercher">
            <button type="submit" class="absolute right-0 bottom-2 mt-5 mr-4">
                <svg class="text-gray-600 h-6 w-6 fill-current" xmlns="http://www.w3.org/2000/svg"
                     xmlns:xlink="http://www.w3.org/1999/xlink" version="1.1" id="Capa_1" x="0px" y="0px"
                     viewBox="0 0 56.966 56.966" style="enable-background:new 0 0 56.966 56.966;" xml:space="preserve"
                     width="512px" height="512px">
            <path
                d="M55.146,51.887L41.588,37.786c3.486-4.144,5.396-9.358,5.396-14.786c0-12.682-10.318-23-23-23s-23,10.318-23,23  s10.318,23,23,23c4.761,0,9.298-1.436,13.177-4.162l13.661,14.208c0.571,0.593,1.339,0.92,2.162,0.92  c0.779,0,1.518-0.297,2.079-0.837C56.255,54.982,56.293,53.08,55.146,51.887z M23.984,6c9.374,0,17,7.626,17,17s-7.626,17-17,17  s-17-7.626-17-17S14.61,6,23.984,6z" />
          </svg>
            </button>
        </div>
    </div> -->
        @if (Route::has('login'))
            <div class="hidden fixed top-0 right-0 px-6 py-4 sm:block">
                @auth
                    <a href="{{ url('/dashboard') }}" class="text-sm text-red-600 underline hover:text-gray-300"
                    >Dashboard</a
                    >
                @else
                    <a href="{{ route('login') }}" class="text-sm text-red-600 underline hover:text-gray-300"
                    >Log in</a
                    >

                    @if (Route::has('register'))
                        <a
                            href="{{ route('register') }}"
                            class="ml-4 text-sm text-red-600 underline hover:text-gray-300"
                        >Register</a
                        >
                    @endif @endauth
            </div>
        @endif

</nav>
@yield('content')

<footer class=" fixed-bottom bg-gray-800 relative pt-1 border-b-2 border-gray-300">
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
