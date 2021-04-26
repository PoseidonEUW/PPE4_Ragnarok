<x-app-layout>
    <x-slot name="header">
        <h2 class="font-semibold text-xl text-white leading-tight">
            {{ __('Mon Avis') }}
        </h2>
    </x-slot>
    <div class="py-12">
        <div class="max-w-7xl mx-auto sm:px-6 lg:px-8">
            <div class="bg-white overflow-hidden shadow-sm sm:rounded-lg">
                <div class="p-6 bg-white border-b border-gray-200">
                    <h2 class="font-semibold text-md text-gray-800 leading-tight mb-4">Mon Avis en Cours :</h2>
                    <form action="/avis"method="POST">
                        @csrf
                        <h2 class="text-xl ml-12  font-semibold underline text-red-600 mb-1"> Mettre votre avis  </h2>
                        <input type="hidden" name="idmanif" value={{$avis->IDMANIF}}>
                        <input type="hidden" name="idpersonne" value={{Auth::user()->id}}>
                        <label class="mx-3" for="noteavis">Note : </label>
                        <input class="text-gray-600" type="number" id="noteavis" name="noteavis" min="1" max="5" value="1">
                        <label class="mx-3" for="libelle">Avis : </label><br>

                        <input type="text" class="text-gray-600 ml-8 h-60" id="libelle" name="libelle" placeholder="Ici!">
                        <x-button class="ml-4">
                            {{ __('Mettre un avis') }}
                        </x-button>
                        {{--                           Les Messages Succés / Erreurs--}}
                                            @if(session()->has('message'))
                                            <div class="alert alert-success">
                                                {{ session()->get('message') }}
                                            </div>
                                        @endif
                    </form>


                </div>
            </div>
        </div>
    </div>

   </x-app-layout>
