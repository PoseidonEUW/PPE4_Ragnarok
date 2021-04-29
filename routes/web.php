<?php


//use App\Http\Controllers\ArtistesController;
use App\Http\Controllers\AvisController;
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
Route::get('/artistes',[PagesController::class,'artistes']);

//Find de main Page
//Controlleur Manifestation
Route::get('/manifestations',[ManifestationController::class,'index']);
Route::resource('/manifestations',ManifestationController::class);
Route::post('/avis',[AvisController::class,'store'])->name('avis.store');

// Fin de Mettre a jour

// Show Billets
Route::get('reservations', function () {
    return view('reservations');
})->middleware(['auth'])->name('reservations');
Route::get('reservations',[ReservationController::class,'index'])->middleware(['auth'])->name('reservations');
Route::post('reservations/{id}',[ReservationController::class,'delete'])->middleware(['auth'])->name('reservations.delete');

// Fin de Show Billets
//Mettre ton avis apres avoir Participer
Route::get('/avis', function () {
    return view('avis');
})->middleware(['auth'])->name('avis');
Route::get('/avis/{IDMANIF}',[ReservationController::class,'create'])->middleware(['auth'])->name('avis');
///
require __DIR__.'/auth.php';
