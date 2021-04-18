<?php


use App\Http\Controllers\ArtistesController;
use App\Http\Controllers\ReservationController;
use App\Models\Personne;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\ManifestationController;
use App\Http\Controllers\PagesController;
use App\Http\Controllers\PersonneController;
use Illuminate\Validation\Rule;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/
// Main Page

Route::get('/',[PagesController::class,'index']);
Route::get('/about-us',[PagesController::class,'aboutus']);

//Find de main Page
//Controlleur Manifestation
Route::get('/manifestations',[ManifestationController::class,'index']);
Route::resource('/manifestations',ManifestationController::class);
// Controlleur Artistes
Route::get('/artistes',[ArtistesController::class,'index']);
//

Route::get('/dashboard', function () {
    return view('dashboard');
})->middleware(['auth'])->name('dashboard');


// Mettre a jour ton email
Route::get('/settings', function () {
    return view('settings',[
        'user'=>request()->user(),

    ]);
})->middleware(['auth'])->name('settings');

Route::post('/settings',function(Request $request){
    $request->validate([
        'email'=>['required','email',Rule::unique('users','email')],

    ]);
    $user = $request->user();
    $user->update([
        'email'=>$request->input('email'),
    ]);


    return redirect()->back();
});

// Fin de Mettre a jour
// Show Billets
Route::get('reservations', function () {
    return view('reservations');
})->middleware(['auth'])->name('reservations');
Route::get('reservations',[ReservationController::class,'index'])->middleware(['auth'])->name('reservations');

// Fin de Show Billets
require __DIR__.'/auth.php';
