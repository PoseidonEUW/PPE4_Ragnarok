@extends('layouts.main')

@section('content')

{{--LOGO + Fond Ecran--}}
    <div class="relative m-auto mt-12 mb-12">
        <div class="object-fill w-full h-64 rounded-lg shadow-2x1 overflow-hidden relative">
            <img src="{{asset('images/netflix-image.jpg')}}" alt="" class="absolute inset-0 h-full w-full object-cover">
            <div class="absolute inset-0 bg-gray-900 bg-opacity-75"></div>
            <div class="flex h-full items-center justify-center relative">
                <img src="{{asset('images/carantec.png')}}" alt="">

            </div>
        </div>

    </div>
{{--Fin de LOGO + Fond Ecran--}}
{{--Premier Container--}}
<div class="static border-b-4 border-red-600 mb-12"></div>
<div class="container mx-auto px4 py16 flex mb-12">
    <img src="{{asset('images/presenter.png')}}" alt="" class=" object-contain ">
    <div class="flex items-center text-gray-300 text-md mt-1 ml-8">
        <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras cursus suscipit interdum. Nam nec libero dictum, ultrices sapien sollicitudin, congue sapien. Nam ut pharetra nibh. Etiam euismod lacus odio, rutrum sagittis mauris tempus in. Praesent imperdiet semper dui sed iaculis. Donec sed nisl in ex luctus tempor. Maecenas feugiat nec massa nec consectetur. Curabitur ipsum quam, sollicitudin non aliquet eu, tincidunt in mi. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.

Cras laoreet semper est eget efficitur. Proin vehicula posuere tempus. Fusce feugiat, ipsum et aliquam mattis, eros magna pulvinar eros, sed fringilla lectus leo at quam. Nunc fermentum magna est, et faucibus arcu efficitur eget. Aliquam ac leo risus. Vivamus ornare dictum euismod. Nunc sed ligula neque. Aliquam sodales, quam non luctus tempor, justo lectus euismod orci, ut tempor nulla enim sed augue. Donec et tincidunt enim, sed egestas dui. Sed quis ullamcorper turpis, vel laoreet tellus. Vivamus quis mi rhoncus, euismod ligula et, ornare nibh. Nulla vitae dolor aliquam, lobortis erat in, aliquam erat. Ut tempus elementum rutrum. Suspendisse vel pellentesque sem, in suscipit lorem.</span>
    </div>


</div>
<div class="container mx-auto px4 py16  flex">
<div class="container mx-auto px4 py16 flex-col">
    <img src="{{asset('images/samantha-gades-fIHozNWfcvs-unsplash.jpg')}}" alt="" class=" object-contain h-92 w-full ">
    <h2 class="text-4xl font-semibold text-gray-300 text-center border-b-2 border-red-600" >
        Les Acteurs
    </h2>
    <div class="flex items-center text-gray-300 text-md mt-1 ml-8">
        <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras cursus suscipit interdum. Nam nec libero dictum, ultrices sapien sollicitudin, congue sapien. Nam ut pharetra nibh. Etiam euismod lacus odio, rutrum sagittis mauris tempus in. Praesent imperdiet semper dui sed iaculis. Donec sed nisl in ex luctus tempor. Maecenas feugiat nec massa nec consectetur. Curabitur ipsum quam, sollicitudin non aliquet eu, tincidunt in mi. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.

Cras laoreet semper est eget efficitur. Proin vehicula posuere tempus. Fusce feugiat, ipsum et aliquam mattis, eros magna pulvinar eros, sed fringilla lectus leo at quam. Nunc fermentum magna est, et faucibus arcu efficitur eget. Aliquam ac leo risus. Vivamus ornare dictum euismod. Nunc sed ligula neque. Aliquam sodales, quam non luctus tempor, justo lectus euismod orci, ut tempor nulla enim sed augue. Donec et tincidunt enim, sed egestas dui. Sed quis ullamcorper turpis, vel laoreet tellus. Vivamus quis mi rhoncus, euismod ligula et, ornare nibh. Nulla vitae dolor aliquam, lobortis erat in, aliquam erat. Ut tempus elementum rutrum. Suspendisse vel pellentesque sem, in suscipit lorem.</span>
    </div>
    <div class="flex text-gray-300 text-sm mt-1">
        <a href="#" class="uppercase object-right hover:text-red-600 ">Plus d'information</a>

    </div>
</div>
    <div class="container mx-auto px8 py16 ml-48 flex-col">
        <img src="{{asset('images/samantha-gades-fIHozNWfcvs-unsplash.jpg')}}" alt="" class=" object-contain h-60 w-full ">

        <div class="flex items-center text-gray-300 text-md mt-1 ml-8">
        <span>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras cursus suscipit interdum. Nam nec libero dictum, ultrices sapien sollicitudin, congue sapien. Nam ut pharetra nibh. Etiam euismod lacus odio, rutrum sagittis mauris tempus in. Praesent imperdiet semper dui sed iaculis. Donec sed nisl in ex luctus tempor. Maecenas feugiat nec massa nec consectetur. Curabitur ipsum quam, sollicitudin non aliquet eu, tincidunt in mi. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.

Cras laoreet semper est eget efficitur. Proin vehicula posuere tempus. Fusce feugiat, ipsum et aliquam mattis, eros magna pulvinar eros, sed fringilla lectus leo at quam. Nunc fermentum magna est, et faucibus arcu efficitur eget. Aliquam ac leo risus. Vivamus ornare dictum euismod. Nunc sed ligula neque. Aliquam sodales, quam non luctus tempor, justo lectus euismod orci, ut tempor nulla enim sed augue. Donec et tincidunt enim, sed egestas dui. Sed quis ullamcorper turpis, vel laoreet tellus. Vivamus quis mi rhoncus, euismod ligula et, ornare nibh. Nulla vitae dolor aliquam, lobortis erat in, aliquam erat. Ut tempus elementum rutrum. Suspendisse vel pellentesque sem, in suscipit lorem.</span>
        </div>


    </div>
</div>

@endsection
