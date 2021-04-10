<?php


use App\Models\Personne;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\ManifestationController;
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

Route::get('/', function () {
    return view('index');
});
Route::view('/evenements','show');
Route::resource('/',ManifestationController::class);
Route::resource('/evenements',ManifestationController::class);
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
require __DIR__.'/auth.php';
